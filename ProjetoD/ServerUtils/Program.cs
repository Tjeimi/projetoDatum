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
}