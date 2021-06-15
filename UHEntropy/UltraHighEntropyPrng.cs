
using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Security.Cryptography; // for testing

namespace UHEntropy
{
   public class UltraHighEntropyPrng
   {
      private int _order;
      private int _carry;
      private int _phase;
      private double[] _intermediates;
      private int _i, _j, _k; // general purpose locals

      private readonly Random _random = new Random(); // Used to simulate javascript's Math.random
   
      public UltraHighEntropyPrng()
      {
         _order = 48; // set the 'order' number of ENTROPY-holding 32-bit values
         _carry = 1;  // init the 'carry' used by the multiply-with-carry (MWC) algorithm
         _phase = _order; // init the 'phase' (max-1) of the intermediate variable pointer
         _intermediates = new double[ _order]; // declare our intermediate variables array

         // when our "uheprng" is initially invoked our PRNG state is initialized from the
         // browser's own local PRNG. This is okay since although its generator might not
         // be wonderful, it's useful for establishing large startup entropy for our usage.		
         //var mash = Mash();		// get a pointer to our high-performance "Mash" hash
         for ( _i = 0; _i < _order; _i++ )
         {
                //_intermediates[ _i ] = Mash(GenerateRandomNumber(0, int.MaxValue).ToString()); // test with real random numbers
                _intermediates[_i] = Mash(_random.NextDouble().ToString().Replace("0.",""));	// fill the array with initial mash hash values
         }
      }

        // this is just here for testing comparisons. Original Random() is actually used.
        public static int GenerateRandomNumber(int minValue, int maxValue)
        {
            byte[] randomBytes = new byte[ 4 ];
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            rng.GetBytes(randomBytes);
            // Convert four random bytes into a positive integer value.
            int seed = ((randomBytes[ 0 ] & 0x7f) << 24) |
                        (randomBytes[ 1 ] << 16) |
                        (randomBytes[ 2 ] << 8) |
                        (randomBytes[ 3 ]);
            Random random = new Random(seed);
            return random.Next(minValue, maxValue);
        }

        // this EXPORTED function is the default function returned by this library.
        // The values returned are integers in the range from 0 to range-1. We first
        // obtain two 32-bit fractions (from rawprng) to synthesize a single high
        // resolution 53-bit prng (0 to <1), then we multiply this by the caller's
        // "range" param and take the "floor" to return a equally probable integer.
        public double Random( int range )
      {
            var tmp = (int)(RawPrng() * 0x200000);
            return Math.Floor(range * ((RawPrng() + (tmp | 0) * 1.1102230246251565e-16))); // 2^-53

        }

      // this EXPORTED function 'string(n)' returns a pseudo-random string of
      // 'n' printable characters ranging from chr(33) to chr(126) inclusive.
      public string RandomString( dynamic count )
      {
         count = Convert.ToInt32(count);
         var stringBuilder = new StringBuilder();
         for ( int i = 0; i < count; i++ )
         {
            //char newChar = Encoding.ASCII.GetString(BitConverter.GetBytes(GenerateRandomNumber(33, 127))).ToCharArray()[0]; // testing with real random numbers
            char newChar = Encoding.ASCII.GetString(BitConverter.GetBytes(33 + (int)Random(94))).ToCharArray()[ 0 ];
            stringBuilder.Append( newChar );
         }
         return stringBuilder.ToString();
      }

      // this PRIVATE (internal access only) function is the heart of the multiply-with-carry
      // (MWC) PRNG algorithm. When called it returns a pseudo-random number in the form of a
      // 32-bit JavaScript fraction (0.0 to <1.0) it is a PRIVATE function used by the default
      // [0-1] return function, and by the random 'string(n)' function which returns 'n'
      // characters from 33 to 126.
      private double RawPrng()
      {
         if ( ++_phase >= _order )
            _phase = 0;
         
         double t = 1768863 * _intermediates[_phase] + _carry * 2.3283064365386963e-10; // 2^-32
         return _intermediates[_phase] = t - (_carry = (int)t | 0);
      }

      /// <summary>
      /// Evolve the generator's internal entropy state
      /// </summary>
      /// <param name="args"></param>
      /// <seealso cref="AddEntropy"/>
      private void Hash( string args )
      {
         for ( _i = 0; _i < args.Length; _i++ )
            for ( _j = 0; _j < _order; _j++ )
            {
               _intermediates[_j] -= Mash( args[_i].ToString() );
               if ( _intermediates[_j] < 0 )
                  _intermediates[_j] = (char) ( _intermediates[_j] + 1 );
               
            }
      }

      /// <summary>
      /// Removes leading and trailing spaces and non-printing control
      /// characters, including any embedded carriage-return (CR) and
      /// line-feed (LF) characters, from any string it is handed
      /// </summary>
      /// <param name="toClean"></param>
      /// <returns></returns>
      public string CleanString( string toClean )
      {
         string cleaned = toClean.Trim(); // remove any/all leading/trailing spaces

         // remove any/all control characters
         const string controlCharactersPattern = "[\x00-\x1F]";
         var cleanControlCharacters = new Regex( controlCharactersPattern );
         cleaned = cleanControlCharacters.Replace( cleaned, string.Empty );

         return cleaned; // return the cleaned up result
      }

      // this EXPORTED "hash string" function hashes the provided character string after first removing
      // any leading or trailing spaces and ignoring any embedded carriage returns (CR) or Line Feeds (LF)
      public void HashString( string input )
      {
         input = CleanString( input );
         Mash( input );								 // use the string to evolve the 'mash' state

         char[] inputAry = input.ToCharArray();
         for ( _i = 0; _i < inputAry.Length; _i++ )  // scan through the characters in our string
         {
            _k = inputAry[_i];      				 // get the character code at the location
            for ( _j = 0; _j < _order -1; _j++ )		 //	"mash" it into the UHEPRNG state
               _intermediates[_j] -= Mash( _k.ToString() );
               if ( _intermediates[_j] < 0 )
                  _intermediates[_j] += 1;
               
            
         }
      }

      /// <summary>
      /// Used to add additional entropy to the Prng
      /// </summary>
      /// <param name="values">Variable number of parameters used to generate additional entropy</param>
      public void AddEntropy(string value)
      {
            Hash(_k++ +  DateTime.UtcNow.Ticks + DateTime.Now.Ticks + value);
      }
        public void AddEntropy() { AddEntropy(""); }
      // if we want to provide a deterministic startup context for our PRNG,
      // but without directly setting the internal state variables, this allows
      // us to initialize the mash hash and PRNG's internal state before providing
      // some hashing input
      public void InitState()
      {
         Mash();													// pass a null arg to force mash hash to init
         for ( _i = 0; _i < _order; _i++ )
         {
            _intermediates[_i] = Mash( ((char)33 + (int)Random(94)).ToString());	// fill the array with initial mash hash values
         }
         _carry = 1;													// init our multiply-with-carry carry
         _phase = _order;  										// init our phase
      }

      /// <summary>
      /// Hashing function
      /// </summary>
      /// <param name="data">Data to hash</param>
      /// <returns>Hashed value</returns>
      /// <remarks> This is based upon Johannes Baagoe's carefully designed and efficient hash function for use with JavaScript.  It has a proven "avalanche" effect such that every bit of the input affects every bit of the output 50% of the time, which is good.</remarks>
      /// <seealso cref="https://web.archive.org/web/20111119022126/http://baagoe.org/en/wiki/Better_random_numbers_for_javascript"/>
        double Mash(string data)
        {
            string x = data == null ? "" : data.ToString();
            uint n = 0xefc8249d;
            double h;
            if (!string.IsNullOrEmpty(x))
            {
                while (x.Length > 0)
                {
                    n += Convert.ToUInt32(x[ 0 ]);
                    x = x.Remove(0, 1);
                    h = 0.02519603282416938 * n;
                    n = (uint)h;
                    h -= n;
                    h *= n;
                    n = (uint)h;
                    h -= n;
                    n += (uint)h * unchecked((uint)0x100000000);
                }
                return n * 2.3283064365386963e-10; // 2^-32
            }
            else
                return n;
        }

        /// <summary>
        /// Hashing function
        /// </summary>
        /// <see cref="Mash()"/>
        private double Mash()
      {
         return Mash( null );
        }
    
}
}