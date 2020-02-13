namespace BlabberApp.Domain
{
    public class Blab : IDatum {
        private System.DateTime _dttm;
        private string _message;
        private string _userId;
        public string Message {
            get {return this._message;}
            set {this._message = value;}
        }
        public System.DateTime DTTM {
            get {return this._dttm;}
            set {this._dttm = value;}
        }

        public string UserID {
            get {return this._userId;}
            set {this._userId = value;}   
        }

        public string getSysId() {
            return "";
        }
    }
}