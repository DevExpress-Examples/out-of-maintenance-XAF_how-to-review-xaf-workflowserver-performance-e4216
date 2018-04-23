using System;
using System.ComponentModel;

using DevExpress.Xpo;
using DevExpress.Data.Filtering;

using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;

namespace Solution1.Module.BusinessObjects {
    [DefaultClassOptions]
    public class Note : BaseObject {
        public Note(Session session)
            : base(session) {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here or place it only when the IsLoading property is false:
            // if (!IsLoading){
            //    It is now OK to place your initialization code here.
            // }
            // or as an alternative, move your initialization code into the AfterConstruction method.
        }
        public string Name {
            get { return GetPropertyValue<string>("Name"); }
            set { SetPropertyValue<string>("Name", value); }
        }
        public bool IsProcessed {
            get { return GetPropertyValue<bool>("IsProcessed"); }
            set { SetPropertyValue<bool>("IsProcessed", value); }
        }
    }

    [DefaultClassOptions]
    public class Task : BaseObject {
        public Task(Session session)
            : base(session) {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here or place it only when the IsLoading property is false:
            // if (!IsLoading){
            //    It is now OK to place your initialization code here.
            // }
            // or as an alternative, move your initialization code into the AfterConstruction method.
        }
        public DateTime CreatedOn {
            get { return GetPropertyValue<DateTime>("CreatedOn"); }
            set { SetPropertyValue<DateTime>("CreatedOn", value); }
        }
        public string Name {
            get { return GetPropertyValue<string>("Name"); }
            set { SetPropertyValue<string>("Name", value); }
        }
        public Note SourceNote {
            get { return GetPropertyValue<Note>("SourceNote"); }
            set { SetPropertyValue<Note>("SourceNote", value); }
        }
        public TaskType TaskType {
            get { return GetPropertyValue<TaskType>("TaskType"); }
            set { SetPropertyValue<TaskType>("TaskType", value); }
        }        
    }

    [DefaultClassOptions]
    public class TaskType : BaseObject {
        public TaskType(Session session)
            : base(session) {
        }
        public string Name {
            get { return GetPropertyValue<string>("Name"); }
            set { SetPropertyValue<string>("Name", value); }
        }
    }
}
