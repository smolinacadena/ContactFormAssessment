# Contact Form

## Instructions

1. Install .NET 5 in your machine. To check this, run `dotnet --version`
2. This project will need an IIS site with the name and an HTTP(80) binding set to `contact.hero.assesment`
3. Open ContactForm.sln with Visual Studio 2019. This project was built using Visual Studio 2019 as it's the only one with support for .NET 5 at the moment.
4. Build the solution and publish using the IISProfile.pubxml publish profile
5. Browse to `http://contact.hero.assessment` and you should the site.
6. If you don't see the site, you'll need to add a hosts entry like this: `127.0.0.1     contact.hero.assessment` 

## Assessment Instructions
- [x] Create a basic MVC web application project in Visual Studio. This project can follow any solution structure you wish, as long as it is easy to navigate to any user.
- [x] Include a README of necessary steps to set up and install your application.
- [x] The application must include a publish profile using Web Deploy to a local IIS website.
- [x] The home page should include a simple contact form. The form must include the following fields:
- [x] First name
- [x] Last name
- [x] Email address
- [x] Phone number
- [x] Contact message
- [x] Upon submission of the contact form, you must perform backend validation on the email format.
- [x] If the form is valid, you must redirect the user to a dedicated thank you page.
- [x] The thank you page should include a re-gurgitation of the form submission details from the user.
- [x] Ensure the solution is secure from cross-site scripting