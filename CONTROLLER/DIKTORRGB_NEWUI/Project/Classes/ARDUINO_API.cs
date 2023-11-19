using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.IO.Ports;
using System.Reflection;
using System.Threading.Tasks;

namespace Project
{
    partial class Form1
    {
        class MyObject
        {
            [JsonProperty("string")]
            public string MyString { get; set; }
        }
        //------------------!!!!!!!!!!!!!! OLD VERSION API ONLY FOR VENT, ACTUAL IN MEMAPI HANDLER
        static string GetJsonHello()
        {
            var jsonObject = new
            {
                mode = "hello",
                //offsets = new[] { "0x2C0" },
            };

            string json = JsonConvert.SerializeObject(jsonObject, Formatting.Indented);
            return json;
        }

        //------------------SET_COLOR--------------------------------------
        static string GetJsonSetRGB(int R = -1, int G = -1, int B = -1)
        {
            if ((R == -1) && (G == -1) && (B == -1)) { return "{}"; }

            string json = "{\"mode\":\"set_color\"";
            if (R >= 0) { json += $",\"r\":\"{R}\""; }
            if (G >= 0) { json += $",\"g\":\"{G}\""; }
            if (B >= 0) { json += $",\"b\":\"{B}\""; }

            json += "}";
            return json;
        }
        //------------------------------------------------------------






        //-------------------------------------------------OTHER-------
        static string GetJsonSetAnimMode(string _anim_num, string _delayanim, string _delaycolor)
        {

            var jsonObject = new
            {
                mode = "set_anim",
                anim_num = $"{_anim_num}",
                delayanim = $"{_delayanim}",
                delaycolor = $"{_delaycolor}",
                //offsets = new[] { "0x2C0" },
            };
            string json = JsonConvert.SerializeObject(jsonObject, Formatting.Indented);
            return json;
        }
        







        /*static string GetSetValueJSON(string _value)
        {
            var jsonObject = new
            {
                mode = "print",
                value = _value,
                //offsets = new[] { "0x2C0" },
            };

            string json = JsonConvert.SerializeObject(jsonObject, Formatting.Indented);
            return json;
        }
        static string GetSetValueWSTRJSON(string _descr, string _value)
        {
            var jsonObject = new
            {
                mode = "print_wstr",
                descr = _descr,
                value = _value,
                //offsets = new[] { "0x2C0" },
            };

            string json = JsonConvert.SerializeObject(jsonObject, Formatting.Indented);
            return json;
        }
        static string GetSetValueWSTRJSON(string _descr, string _value, int _row)
        {
            var jsonObject = new
            {
                mode = "print_wstr",
                descr = _descr,
                value = _value,
                row = _row,
                //offsets = new[] { "0x2C0" },
            };

            string json = JsonConvert.SerializeObject(jsonObject, Formatting.Indented);
            return json;
        }*/

    }
}
