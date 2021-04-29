# Ecommerce-App
## Sprint 1 milestone 1

Admin Dashboard  
Create the general Administrative Dashboard workflow, User Interface/Design, screens, and initial database design and wiring.  

User Stories and Tasks  
Divide your work evenly amongst your team members.  

As an admin user, I would like to have a dashboard where I can see a list of product categories  
As an admin user, I would like to view a detail page for each category so that I can eventually edit its data or delete it  
As an admin user, I would like to see a list of the products assigned to a category on the category details page  
As an admin user, I would like a detail page for each product so that I can eventually edit its data or delete it  
Guidance  
Scaffold out the admin dashboard workflow using MVC with mock data  
What pages do you need?  
What data do you need to make each page function properly?  
What Data Models, Properties, Navigation Properties or DTOs do you need?  
An ERD is a great place to start  
Do you need any view models?  
Configure your core: DbContext with seed data, Interfaces/Services, Routing  

## Sprint 1 milestone 2

Work together with your partner(s) to complete this lab.  

NOTE: Your team workflow will live in Azure Dev Ops. Use this tool to store your project repository code, user stories, and general overall workflow. Azure DevOps CheatSheet  

Your team will be evaluated and graded at the end of every sprint for the individual milestones and overall presentation of the sprint/project. Each day the previous day’s milestones build off each other as the project progresses. Stay on top of your work, Communicate, and work together.  

Admin Dashboard  
Using Identity, Roles, and Policies, “protect” every screen and feature within the Admininistrative Dashboard so that only properly authenticated and authorized users have access to it.  

User Stories and Tasks  
Divide your work evenly amongst your team members.  

As the site owner, I would like to secure the admin dashboard so that only users with an administrative role can access it  
As an administrator I would like to ensure that only users with create permissions can add categories or products  
As an administrator I would like to ensure that only users with update permissions can modify categories or products  
As an administrator I would like to ensure that only users with update permissions can add a product to a category  
As an administrator I would like to ensure that only users with delete permissions can delete categories or products   

Due to the fact that we are working on this lab as individuals, I am only doing the first 3 user stories. There is currently no ERD. 




## Sprint 1 milestone 3

User Stories and Tasks  
Divide your work evenly amongst your team members.  
  
As an administrator I would like add and save a new category so that I can expand my product lines  
As an administrator I would like add and save a new produc so that I can expand my inventory  
As an administrator I would like to associate a product to a category so that my users can more easily browse our inventory  
As an administrator I would like to be able to delete products and categories as needed  
As an administrator I would like to be able to edit/modify categories so that I can change my storefront structure in real time  
As an administrator I would like to be able to edit/modify products so that I can change my inventoryt in real time  

## Sprint 1 Milestone 4

Admin Dashboard
When adding/editing products, we’ll be adding the ability to upload an image for each product. We’ll be storing these the cloud. Specifically, we’ll be using Azure Blob Storage Containers which allow us to upload an image to remote storage and obtain a URL so we can eventually view them on a web page.

User Stories and Tasks
Divide your work evenly amongst your team members.

As an administrator I would like upload a picture for each product so that my shoppers will know what our products look like
As an administrator I would like replace a picture for each product so that I can keep my inventory up to date
As an administrator, I would like a preview of my product listings so that I can see what my customers will see in the online store