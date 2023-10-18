using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contacts_management_app.contactClass
{
    public class Contacts
    { 
        public int ID { get; set; }
        public string NAME { get; set; }
        public string TEL { get; set; }
        public string MAIL { get; set; }
        public string MEMO { get; set; }
    }

    public class ContactList
    {
        public List<Contacts> Data { get; }

        // コンストラクタ(データ入力)
        public ContactList()
        {
            Data = new List<Contacts> {
                new Contacts { ID=1, NAME="武宮勇貴", TEL="09092390645", MAIL="newchallenge3625@gmaail.com", MEMO="特になし" },
                new Contacts { ID=2, NAME="鈴木二郎", TEL="09023659876", MAIL="korin2543@gmail.com", MEMO="明日休み" },
                new Contacts { ID=3, NAME="佐藤三郎", TEL="07056439745", MAIL="tokutoku0921@gmail.com", MEMO="課長代理" },
                new Contacts { ID=4, NAME="佐藤三郎", TEL="08043216674", MAIL="meizi0645@gmail.com", MEMO="土日休み" },
            };

        }
    }
}
