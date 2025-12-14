using System;

namespace DayTradingApp
{
    // Simple session holder for the currently authenticated app user
    public static class UserSession
    {
        // The lightweight user object used across the app
        public static User Current { get; set; }

        public static bool IsAuthenticated => Current != null && !string.IsNullOrWhiteSpace(Current.Id);

        public static void Clear()
        {
            Current = null;
        }
    }
}
