## Greg and Grant

We used C# to develop the solution, and [nUnit](http://www.nunit.org/) to test it.

At first, we were trying to find the divisors of _every_ number, until we found one with 500 divisors. Even if we did find one, it might not be a Triangle Number, so the result would probably be wrong.

    while (true)
    {
        var result = CalculateDivisors(i);

        if (result.Count >= divisors)
            return result.Max();

        i++;
    }

Greg realized an optimization that brought what would've been many minutes down to a few seconds.

We're only interested in Triangle Numbers, so only test those. This means instead of testing every number from 1 thru 28, we just test 1, 3, ... 21, 28 and so on...

    while (true)
    {
        var r = CalculateTriangleNumber(i);

        var result = CalculateDivisors(r);

        if (result.Count >= divisors)
            return result.Max();

        i++;
    }

We ran into one more snag at the end. We thought we had the right code to generate the solution, but it still wouldn't end. Pausing execution showed a huge number, larger than the correct solution. We had completely overshot the target number.

The culprit was this line. It needed to be `>=`, since there's (apparently) no Triangle Number with _exactly_ 500 divisors, and the instructions specify _"over five hundred divisors"_.

    if (result.Count == divisors)
