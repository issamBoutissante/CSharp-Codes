using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            //videoEncoder videoEncoder = new videoEncoder();//Publisher
            //notification notification = new notification();//Subriber
            //videoEncoder.myevent += notification.notify;

            //videoEncoder.EncodingVideo();
            //Console.ReadKey();


            YoutubeChanel newChanel = new YoutubeChanel();
            Person issam = new Person("issam", newChanel);
            Person Chaimae = new Person("Chaimae", newChanel);
            newChanel.ShareVideo();
            newChanel.ShareState();
            Console.ReadKey();

        }
    }
    class notification
    {
        public void notify()
        {
            Console.WriteLine("the video has been encoded");
        }
    }

    class Person
    {
        public Person()
        {
        }
        public Person(string name, YoutubeChanel youtubeChanel)
        {
            youtubeChanel.SendNotification += (object sender, ExtraInfo info) =>
            {
                Console.WriteLine(name+" has opend the "+info.type);
            };
        }
    }
    class ExtraInfo
    {
        public string type;
    }
    class YoutubeChanel
    {
        public delegate void YoutubeEventHandler(object sender,ExtraInfo info);
        public event YoutubeEventHandler SendNotification;
        public void ShareVideo()
        {
            SendNotification(this, new ExtraInfo { type="Video"});
        }
        public void ShareState()
        {
            SendNotification(this,new ExtraInfo { type="State"});
        }
    }
}
