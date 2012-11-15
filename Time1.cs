using System;

public class Time1
{
    private int hour;
    private int min;
    private int sec;

    public void setTime( int h, int m, int s)
    {
        hour = ((h >= 0 && h<24)? h:0); //validate hour
        min = ((m >=0 && m<60)? m:0);//validate minute
        sec = ((s >=0 && s<60)? s:0);//validate seconds
    }
        //convert to string in universal time format (HH:mm:ss)
    public string ToUniversalFormat()
    {
        return string.Format("{0:D2}:{1:D2}:{2:D2}", hour, min, sec);
    }

    public override string ToString()
    {
        return string.Format("{0}:{1:D2}:{2:D2} {3}", ((hour == 0 || hour == 12) ? 12 : hour % 12), min, sec, (hour < 12 ? "AM" : "PM"));
    }
	
}

