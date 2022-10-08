using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stripe;
using System.Windows;
using System.Diagnostics;
using System.Net.Mail;
using System.Net;
using notary.assistant.lora.Views.Windows;

namespace notary.assistant.lora.Licensing
{
    public class StripePaymentsGateway
    {
		public async Task<Customer> CreateCustomerAsync(string email, Customer customer, string password_hash)
        {
            var options = new CustomerCreateOptions
            {
                Email = email,
                Name = customer.Name,
				<!-- set all other customer fields -->

                Metadata = new Dictionary<string, string> {
                    { "PasswordHash", password_hash }
                }
            };
            var service = new CustomerService();
            Customer new_customer = await service.CreateAsync(options);
            return new_customer;
        }
		
		
		
	}	
}