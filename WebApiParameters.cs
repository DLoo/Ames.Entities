using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Ames.Entities {
    public class UploadFileInfo {
        public UploadFileInfo() {
            ContentType = "application/octet-stream";
        }
        public string Name { get; set; }
        public string FileName { get; set; }
        public string ContentType { get; set; }
        public byte[] ByteArray { get; set; }
    }

    public class WebApiParameters {
        public IDictionary<string, string> Parameters { get; set; }
        public IEnumerable<UploadFileInfo> UploadFiles { get; set; }

    }
}
