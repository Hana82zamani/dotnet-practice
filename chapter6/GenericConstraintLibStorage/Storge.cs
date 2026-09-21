namespace StorageLibGenericConstraint;

public class Storge
{
    public static T Save<T>(T value) where T:class
    {
        return value;
    }

}
//  where T: class با استفاده از  generic  استفاده از محدودیت 


