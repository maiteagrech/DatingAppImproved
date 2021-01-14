using System;

namespace dating_app_api.Extensions
{
    public static class DateTimeExtension
    {
        public static int CalculateAge(this DateTime dateOfBirth)
        {
            var today = DateTime.Today;
            var age = today.Year - dateOfBirth.Year;
            if(dateOfBirth.Date > today.AddYears(-age)) age--;
            return age;
        }
    }
}