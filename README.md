# Tip Calculator

A tip calculating console app.  This app includes:

- [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)

- input validation
```C#
  // check if the input was a number
            double billTotal;
            var isValid = Double.TryParse(total, out billTotal);
            if (!isValid)
            {
                Console.WriteLine("\nThat is not a number, try again\n");
                total = Console.ReadLine();
                billTotal = Double.Parse(total);
            }
```

## Tipping Percentages Based On Service Quality

- okay 18%
- good 20%
- great 25%

## App In Action
![](https://i.imgur.com/6pKtM5R.png)
