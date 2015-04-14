
## Marling

I had written a short C app to solve it.
The prob12-slow.c was the brute force version, it ran in 22minutes.

gcc prob12-slow.c -O2 -o prob12-slow

prob12.c on the other hand, limited the scope to the sqrt (double counting divisors), and ran in 250ms.

gcc prob12.c -lm -O2 -o prob12


