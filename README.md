# Send SMTP Email using DLL
DLL to send SMTP emails<br>

### Parameters:
<pre>
- sender     | The email that will be sent from
- receiver   | Who will receive this email (for more than one use ";" to separate)
- subject    | Subject of the email
- body       | HTML string
- SMTPClient | The address of your SMTP server
- Priority   | 0 -> High / 1 -> Medium / 2 -> Low (None for medium)
</pre>
  
### Output:
(It always return an string)
<pre>
If it success, will return "SUCCESS - Email sent to: 'receiver'".
If it fails, will return "ERROR - While sending email: 'error'".
</pre>

### Usage:
This DLL is currently being used as alert for OpenEdge Progress' Apps
