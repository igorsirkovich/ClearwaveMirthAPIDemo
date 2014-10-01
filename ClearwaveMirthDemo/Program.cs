using System;
using System.Collections.Generic;
using System.Text;

namespace ClearwaveMirthDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var clearwaveXMLMessage = @"
<message>
    <type>A04</type>
    <organizationId>123</organizationId>
    <patient>
        <patientId>123</patientId>
        <lastName>Doe</lastName>
        <firstName>John</firstName>
        <dateOfBirth>19850502</dateOfBirth>
        <gender>M</gender>
    </patient>
</message>
";
            using (var service = new ClearwaveMirthService())
            {
                service.Url = "http://64.88.177.104:PORT/services/SERVICENAME";  // replace PORT and SERVICENAME from specification
                var response = service.acceptMessage(clearwaveXMLMessage);
                Console.WriteLine("Response From Clearwave: " + response);
                Console.ReadLine();
            }
        }
    }
}
