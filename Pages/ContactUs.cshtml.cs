using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace WebApplication1swe.Pages
{
    public class ContactUsModel : PageModel
    {
        public string SubmitMessage { get; set; }
        public bool IsSuccess { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync(
            string CustomerName,
            string CompanyName,
            string PhoneNumber,
            string EmailAddress,
            string City,
            string ProductInterestedIn,
            string RequiredQuantity,
            string Message)
        {
            // Validate form data
            if (string.IsNullOrWhiteSpace(CustomerName) ||
                string.IsNullOrWhiteSpace(CompanyName) ||
                string.IsNullOrWhiteSpace(PhoneNumber) ||
                string.IsNullOrWhiteSpace(EmailAddress) ||
                string.IsNullOrWhiteSpace(City) ||
                string.IsNullOrWhiteSpace(ProductInterestedIn) ||
                string.IsNullOrWhiteSpace(RequiredQuantity) ||
                string.IsNullOrWhiteSpace(Message))
            {
                SubmitMessage = "Please fill in all required fields.";
                IsSuccess = false;
                return Page();
            }

            try
            {
                // In a real application, you would:
                // 1. Save the inquiry to a database
                // 2. Send an email notification to the business
                // 3. Send a confirmation email to the customer

                // For now, we'll just show a success message
                SubmitMessage = "Thank you for your inquiry! We will get back to you within 24 hours.";
                IsSuccess = true;

                // Clear form after successful submission
                await Task.Delay(2000); // Simulate processing
                return Page();
            }
            catch (Exception ex)
            {
                SubmitMessage = $"An error occurred while processing your inquiry. Please try again or contact us directly.";
                IsSuccess = false;
                return Page();
            }
        }
    }
}
