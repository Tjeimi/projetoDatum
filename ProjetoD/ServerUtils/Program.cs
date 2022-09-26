using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

namespace serverUtils;
public class Utils {
    public static Models.ParametersModel ReadParms() {
        using (StreamReader r = new StreamReader("C:\\Datum\\datum.json")) {
            string json = r.ReadToEnd();
            var parms = JsonSerializer.Deserialize<Models.ParametersModel>(json);
            return parms!;
        }
    }

    public static String GetSha256(string value) {
        StringBuilder Sb = new StringBuilder();

        using (var hash = SHA256.Create()) {
            Encoding enc = Encoding.UTF8;
            byte[] result = hash.ComputeHash(enc.GetBytes(value));

            foreach (byte b in result)
                Sb.Append(b.ToString("x2"));
        }

        return Sb.ToString();
    }

}