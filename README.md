# WepApiAuthentication
This is an answer based on my StackOverflow question https://stackoverflow.com/questions/49394310/owin-authentication-send-custom-field-when-authenticating

**Here it is showed how to add a custom param when Authenticating using Owin**

1) Look at \Views\Home\Index.cshtml
Find this line data: { grant_type: 'password', username: user, password: pwd, customer: 'MyCustomer' },
You note here that we have an additional parameter CUSTOMER

2) Now look at \Providers\ApplicationOAuthProvider.cs
Here you have to look at two places:
First method ValidateClientAuthentication, and you will see this code

string[] customer = context.Parameters.Where(x => x.Key == "customer").Select(x => x.Value).FirstOrDefault();
            if (customer.Length > 0 && customer[0].Trim().Length > 0)
            {
                context.OwinContext.Set<string>("Customer", customer[0].Trim());
            }
            
Then you have to look to method GrantResourceOwnerCredentials

string customer = context.OwinContext.Get<string>("Customer");

This way you manage the custom Field CUSTOMER sent in the JS call, and you can add any other custom field as needed

-----------------------------------------------
**Aother way to get the param is** (on method _GrantResourceOwnerCredentials_)

var param = data.Where(x => x.Key == "customer").Select(x => x.Value).FirstOrDefault();

