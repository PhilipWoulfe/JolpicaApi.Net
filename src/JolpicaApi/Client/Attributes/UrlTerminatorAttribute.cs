using System;

namespace JolpicaApi.Client.Attributes
{
    /// <summary>
    /// Attribute to mark a property as a URL terminator.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class UrlTerminatorAttribute : Attribute
    {
    }
}