using System;
using System.IO;
using System.Net;
using System.Text;

namespace Browser
{
    class HTTP
    {
        
        public String Get(String url)
        {
            try
            {
                // Create a new instance of URI to pass to HTTPWebResponse
                Uri addr = new UriBuilder(url).Uri;
                // Create the HTTP webrequest and get the response
                HttpWebResponse response = HttpWebRequest.Create(addr).GetResponse() as HttpWebResponse;
                // If status is OK, get the response stream, else return null
                return CheckStatus(response) ? ResponseStream(response) : null;
            }
            catch (WebException e)
            {
                // get the code for the exception
                return getCode(url);

            }
            catch (Exception e)
            {
                // return the exception message
                return e.Message;

            }
        }

        // Check if status is OK
        public bool CheckStatus(HttpWebResponse res)
        {
            return (res.StatusCode == HttpStatusCode.OK);
        }

        public string getCode(string url)
        {
            try
            {
                // Create response
                HttpWebResponse response = HttpWebRequest.Create(url).GetResponse() as HttpWebResponse;

                // Return relevant code and message
                switch (response.StatusCode)
                {
                    case HttpStatusCode.OK:
                        return "OK 200";
                    case HttpStatusCode.BadRequest:
                        return "400 Bad Request";
                    case HttpStatusCode.Forbidden:
                        return "403 Forbidden";
                    case HttpStatusCode.NotFound:
                        return "404 Not Found";
                    default:
                        return response.StatusDescription;
                }

            }
            // Catch exception and return code
            catch (WebException e)
            {
                var response = (HttpWebResponse)e.Response;

                if (e.Status == WebExceptionStatus.ProtocolError)
                {
                    switch (response.StatusCode)
                    {
                        case HttpStatusCode.OK:
                            return "OK 200";
                        case HttpStatusCode.BadRequest:
                            return "400 Bad Request";
                        case HttpStatusCode.Forbidden:
                            return "403 Forbidden";
                        case HttpStatusCode.NotFound:
                            return "404 Not Found";
                        default:
                            return response.StatusDescription;
                    }
                }
                return response.StatusDescription;
            }
            catch (Exception e)
            {
                // return message for this exception
                return e.Message;

            }

        }

        public String ResponseStream(HttpWebResponse response)
        {
            // Get the stream that is used to read the body of the response 
            Stream receiveStream = response.GetResponseStream();
            StreamReader readStream;

            // Get charachters if the charachter set is not null
            if (response.CharacterSet == null)
                readStream = new StreamReader(receiveStream);
            else
                readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));

            String stream = readStream.ReadToEnd();

            return stream;

        }
    }
}
