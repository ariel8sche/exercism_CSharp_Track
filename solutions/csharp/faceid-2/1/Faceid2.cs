public class FacialFeatures
{
    public string EyeColor { get; }
    public decimal PhiltrumWidth { get; }

    public FacialFeatures(string eyeColor, decimal philtrumWidth)
    {
        EyeColor = eyeColor;
        PhiltrumWidth = philtrumWidth;
    }
        public bool Equals(FacialFeatures? other)
    {
        if (other is null) return false;
        if (ReferenceEquals(this, other)) return true;

        return EyeColor == other.EyeColor &&
               PhiltrumWidth == other.PhiltrumWidth;
    }

    public override bool Equals(object? obj)
        => Equals(obj as FacialFeatures);

    public override int GetHashCode() => HashCode.Combine(EyeColor, PhiltrumWidth);
    
}

public class Identity
{
    public string Email { get; }
    public FacialFeatures FacialFeatures { get; }

    public Identity(string email, FacialFeatures facialFeatures)
    {
        Email = email;
        FacialFeatures = facialFeatures;
    }

    public bool Equals(Identity? other)
    {
        if (other is null) return false;
        if (ReferenceEquals(this, other)) return true;

        return Email == other.Email &&
               FacialFeatures.Equals(other.FacialFeatures);
    }

    public override bool Equals(object? obj)
        => Equals(obj as Identity);

    public override int GetHashCode() => HashCode.Combine(Email, FacialFeatures);
}

public class Authenticator
{
    private readonly Identity admin = new Identity("admin@exerc.ism", new FacialFeatures("green", 0.9m));
    private Identity ?registeredIdentity;

    public static bool AreSameFace(FacialFeatures faceA, FacialFeatures faceB)
    {
        return faceA.Equals(faceB);
    }

    public bool IsAdmin(Identity identity)
    {
        return admin.Equals(identity);
    }

    public bool Register(Identity identity)
    {
        if (registeredIdentity == null || !registeredIdentity.Equals(identity))
        {
            registeredIdentity = identity;
            return true;
        }

        return false;
    }

    public bool IsRegistered(Identity identity)
    {
        if (registeredIdentity != null)
        {
            return registeredIdentity.Equals(identity);
        }
        return false;
    }
        
    public static bool AreSameObject(Identity identityA, Identity identityB)
    {
        return ReferenceEquals(identityA, identityB);
    }
}
