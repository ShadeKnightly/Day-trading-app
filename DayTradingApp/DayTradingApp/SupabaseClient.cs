using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayTradingApp {
    public static class SupabaseService {
        private static Supabase.Client _client;

        public static async Task<Supabase.Client> GetAsync() {
            if (_client != null)
                return _client;

            var url = Environment.GetEnvironmentVariable("SUPABASE_URL");
            var anonKey = Environment.GetEnvironmentVariable("SUPABASE_ANON_KEY");

            var options = new Supabase.SupabaseOptions {
                AutoConnectRealtime = false,
            };

            _client = new Supabase.Client(url, anonKey, options);
            await _client.InitializeAsync();

            return _client;
        }
    }

}
