using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Event
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "模拟电话来电提醒";

Phone phone = new Phone(13888888888);
phone.CallAlert += new EventHandler<CallEventArgs>(phone_CallAlert);//添加来电提醒事件
phone.Call(13999999999);
            Console.ReadLine();
        }

//来电提醒事件函数
static void phone_CallAlert(object sender, CallEventArgs e)
{
    Phone phone = sender as Phone;
    Console.WriteLine("号码{0}接收到来自{1}的呼叫...",phone.Number, e.Number);
}
    }
//来电提醒事件参数
class CallEventArgs : EventArgs
{
    public readonly long Number;                        //来电号码    
    public CallEventArgs(long number) { this.Number = number; }
}
//电话类
class Phone
{
    public event EventHandler<CallEventArgs> CallAlert; //来电提醒事件
    public readonly long Number;                        //本机电话号码
    public Phone(long number) { this.Number = number; }
    public void Call(long number)                       //来电
    {
        if (CallAlert != null) CallAlert(this, new CallEventArgs(number));//触发来电提醒事件
    }
}

}
