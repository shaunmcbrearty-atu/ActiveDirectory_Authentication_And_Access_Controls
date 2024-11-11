# COMP08141: Active Directory Authentication And Basic RBAC Using C#.NET

This C#.NET code sample demonstrates how to authenticate a Windows User Account to an instance of Microsoft Windows Server Active Directory Domain Services. In addition, it also demonstrates how to determine if a Windows User Account is a member of a specified User Group within an instance of Microsoft Windows Server Active Directory Domain Services. As discussed in the associated lecture, both represent core operations that are are performed as part of any Role-Based Access Control (RBAC) strategy.

Note that the code sample is pre-configured to utilse the following settings:
- Active Directory Server associated with the `ITSLIGO.LAN` Domain.
- The `Test` User Account (with Password value `Password123*`).
- `Bank Teller` User Group.

Active Directory Domain Services has been pre-installed and pre-configured for you on the `SSD_Assignment` virtual machine that has been provided to you as part of the assignment for the module (available on [Microsoft Azure Lab Services](https://labs.azure.com/)).  In addition, the `Bank Teller` user group has also been pre-created for you.

If you wish to use the code sample 'as-is', you must:
- Manually create the `Test` User Account using the `Active Directory Users and Computers` application - [see instructions below](https://github.com/shaunmcbrearty-atu/ActiveDirectory_Authentication_And_Access_Controls?tab=readme-ov-file#user-management-in-active-directory-domain-services).
- Manually add the `Test` User Account to the `Bank Teller` User Group using the `Active Directory Users and Computers` application - [see instructions below](https://github.com/shaunmcbrearty-atu/ActiveDirectory_Authentication_And_Access_Controls?tab=readme-ov-file#group-member-management-in-active-directory-domain-services).

## User Management in Active Directory Domain Services

Active Directory User Accounts can be created using the `Àctive Directory Users and Computers` application on instances of Windows Servers with Active Directory Domain Services installed.
The `Àctive Directory Users and Computers` application can be found at the following location: `Start Menu > Windows Administrative Tools > Active Directory Users and Computers`.

User Accounts can be created within the `Àctive Directory Users and Computers` application by right-clicking on the `Users` Organisation Unit (OU), selecting `New > User` from the resulting menu and populating the resulting form with the information associated with the new User Account to be created (see screenshot below with relevant information highlighted).

<img src='/Images/AD_DS_User_Management.png' />

## Group Member Management in Active Directory Domain Services

Pre-existing User Accounts can be added to pre-existing User Groups using the `Àctive Directory Users and Computers` application on instances of Windows Servers with Active Directory Domain Services installed.

This can be done as follows:

- Locate the desired User Account within the `Users` Organisation Unit (OU).
- Right-click on the desired User Account and select the `Properties` option from the resulting menu.
- In the resulting `User Properties` window, select the `Member Of` tab, and then select the `Add` button.
- In the resulting `Select Groups` window, enter the name of the desired Group in the text field labelled _'Enter the object names to select'_ and select the `Check Names` button. This in turn will search the Directory for any groups that contain the text value inputted.
- If multiple groups contain the text values inputted, the `Multiple Names Found` window will be displayed. Choose the desired Group Name from the list of names displayed and select the `OK` button.
- See screenshot below with relevant information highlighted.

- <img src='/Images/AD_DS_Group_Management.png' />


## Login Auditing

By default, Active Directory Domain Services does not maintain a record of Successful/Failed logon attempts. 

Logging of this information can be enabled by configuring the settings outlined in the article available at the following [link](https://www.lepide.com/blog/audit-successful-logon-logoff-and-failed-logons-in-activedirectory/).