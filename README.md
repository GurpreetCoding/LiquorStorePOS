# LiquorStorePOS

# Description:
### My application is a Point of Sales System which helps the user, mainly business owners, with retail business operations such as ringing up customers, storing product info into a database and providing analytics of margins/profits.
### The technologies I used to create this application was mainly C#, because of its support of Winforms. It was easy to understand and configure. I used MySQL due to my previous experience using it. Also it being a relational database helps with the POS software.

# Problems I encountered:
### - The databases tables foreign keys weren't linking (Error Code: SQL 1452). I couldn't find the solution to the problem on the internet. After tinkering around for a few hours, I noticed that some of the tables were different types such as InnoDB and MYISAM. I changed all of the tables type to InnoDB which fixed the issue.
### - I had issues with winform where the methods that I linked to a winform object such as textbox, panel wouldn't work/ crash. I found the solution to this problem with comparing what I was changing from the last time it was working. The problem was when a new object was added to winforms, the form1.designer.cs would delete the link between the object and method. I fixed it by putting the link in the initialize() method.


