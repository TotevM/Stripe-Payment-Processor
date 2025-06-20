# Stripe Payment Processor (Luxora)

A modern e-commerce web application for selling jewelry, featuring secure Stripe payment integration, user authentication, and a full shopping experience.

## Main Features
- **Stripe Payments**: Secure online payments via Stripe Checkout.
- **User Authentication**: Register, login, and manage accounts with ASP.NET Core Identity.
- **Shopping Cart**: Add, update, or remove products; view cart summary with tax calculation.
- **Order Management**: Place orders, view order history, and filter by date.
- **Responsive UI**: Modern, mobile-friendly design using Bootstrap 5 and custom CSS.

## Technologies Used
- **Backend**: ASP.NET Core 8, Entity Framework Core, C#
- **Frontend**: Razor Pages, Bootstrap 5, jQuery
- **Database**: SQL Server
- **Payments**: Stripe.net SDK
- **Authentication**: ASP.NET Core Identity

## Getting Started
1. **Clone the repository**
2. **Configure the database**
   - Update `SPP.Web/appsettings.json` with your SQL Server connection string.
3. **Set Stripe API keys**
   - Add your Stripe Secret Key to user secrets or environment variables as `StripeAPI:SecretKey`.
4. **Run database migrations**
   - The app auto-applies migrations on startup;
5. **Run the application**