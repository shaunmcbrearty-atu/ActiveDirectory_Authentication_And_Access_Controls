using System.DirectoryServices.AccountManagement;//Must Be Manually Installed Using NuGet Package Manager
using System.Net;

public class Program
{
    public static void Main()
    {

        string domainName = "ITSLIGO.LAN";//Name Of AD-DS Domain Being Authenticated To/Searched

        string username = "Test";//SAM Name Of User Account
        string password = "Password123*";//Password For The User Account Specified Above - Note That A Hard Coded Password Is Used Here For Ease Of Demonstration/Explanation; In Practice, Should Be Inputted By A User At Runtime.

        string groupName = "Bank Teller";//User Group Name

        //Verfiy Validity Of User Credentials

        PrincipalContext domainContext = new PrincipalContext(ContextType.Domain, domainName);
        bool validCreds = domainContext.ValidateCredentials(username, password);

        //Verify Group Membership Of User Account

        UserPrincipal userPrincipal = UserPrincipal.FindByIdentity(domainContext, IdentityType.SamAccountName, username);
        bool isGroupMember = userPrincipal.IsMemberOf(domainContext, IdentityType.SamAccountName, groupName);//Throws Exception Of Invalid Group Name Supplied
       
        //Output

        if(validCreds && isGroupMember)
        {
            Console.WriteLine("User Is Authorized To Perform Access Control Protected Action");
        }

        else
        {
            Console.WriteLine("User Is Not Authorized To Perform This Action.");
            if (validCreds == false)
                Console.WriteLine("Invalid User Credentials Provided.");
            if (isGroupMember == false)
                Console.WriteLine("User Is Not A Member Of The Authorized User Group.");
        }

    }

}