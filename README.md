# CSharp UHEPRNG Ultra High Entropy Pseudo-Random Number Generator WITH GUI

This is an Ultra High Entropy Pseudo-Random Number Generator for use when you do not have a cryptographically secure source of data available.  It was developed by the Gibson Research Corporation and released into the public domain. You can read more about it here: https://www.grc.com/otg/uheprng.htm

Along with the C# port .cs file is a GUI that duplicates all the functions of the javascript on that page, using insecure Math.Random, allows generation of arbitrarily long ASCII strings, lists of numbers with dynamic ranges, includes export functionality, and provides a histogram so you can see how random your ASCII output is.

![GUI](https://github.com/firepacket/CSharp-UHEPRNG-Ultra-High-Entropy-Pseudo-Random-Number-Generator-WITH-GUI/blob/main/gui.jpg)

![EXPORT](https://github.com/firepacket/CSharp-UHEPRNG-Ultra-High-Entropy-Pseudo-Random-Number-Generator-WITH-GUI/blob/main/exportnums.jpg)

There is also commented out code that uses a real cryptographic RNG provider so you can compare the differences of output in the histogram.

![HISTOGRAM](https://github.com/firepacket/CSharp-UHEPRNG-Ultra-High-Entropy-Pseudo-Random-Number-Generator-WITH-GUI/blob/main/historgram.jpg)

Please tell me if you notice any flaws or problems.
