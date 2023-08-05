namespace FootballRefereeManagementSystem.Common.CustomValidationAttributes
{
    using System;
    using System.ComponentModel.DataAnnotations;

    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class PhoneNumberAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if (value is null)
            {
                // The attribute only check if there is value,
                // this way if the property is not required it won't throw error
                return true;
            }

            string phoneNumber = value.ToString()!;
            return phoneNumber.StartsWith("0");
        }
    }
}
