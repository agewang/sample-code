// Install the Java helper library from twilio.com/docs/java/install

import com.twilio.Twilio;
import com.twilio.base.ResourceSet;
import com.twilio.rest.monitor.v1.Event;
import org.joda.time.DateTime;

public class Example {
    // Find your Account Sid and Token at twilio.com/console
    // DANGER! This is insecure. See http://twil.io/secure
    public static final String ACCOUNT_SID = "ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
    public static final String AUTH_TOKEN = "your_auth_token";

    public static void main(String[] args) {
        Twilio.init(ACCOUNT_SID, AUTH_TOKEN);
        ResourceSet<Event> events = Event.reader()
            .setEndDate(new DateTime(2015, 4, 1, 0, 0))
            .setStartDate(new DateTime(2015, 3, 1, 0, 0))
            .read();

        for(Event record : events) {
            System.out.println(record.getSid());
        }
    }
}