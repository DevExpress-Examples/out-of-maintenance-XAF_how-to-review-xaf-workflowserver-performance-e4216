using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.ExpressApp;

namespace WorkflowServerService2 {
    public class ServerApplication : XafApplication {
        protected override DevExpress.ExpressApp.Layout.LayoutManager CreateLayoutManagerCore(bool simple) {
            throw new NotImplementedException();
        }
        public void Logon() {
            base.Logon(null);
        }
    }
}
