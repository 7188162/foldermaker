using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FolderMaker {
    class FolderItem {
        public string FolderName { set; get; }

        public FolderItem (String foldername) {
            this.FolderName = foldername;
        }

    }
}
