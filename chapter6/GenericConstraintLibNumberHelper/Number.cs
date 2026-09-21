namespace NumberHelperLibGenericConstraint;

public class NumberHelper
{
    public static T GetDefault<T>()where T : struct
    {
        return default; // استفاده از مقدار پیشفرض
    }

}
