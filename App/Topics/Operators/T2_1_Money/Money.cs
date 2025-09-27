namespace App.Topics.Operators.T2_1_Money;

public struct Money : IEquatable<Money>
{
    public string Currency { get; }
    public long Amount { get; }

    public Money(string currency, long amount)
    {
        if (string.IsNullOrWhiteSpace(currency))
            throw new ArgumentException("Currency cannot be null or empty", nameof(currency));

        Currency = currency.ToUpperInvariant();
        Amount = amount;
    }

    public bool Equals(Money other)
    {
        return Currency == other.Currency && Amount == other.Amount;
    }

    public override bool Equals(object obj)
    {
        return obj is Money other && Equals(other);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Currency, Amount);
    }

    public static bool operator ==(Money left, Money right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(Money left, Money right)
    {
        return !left.Equals(right);
    }
}