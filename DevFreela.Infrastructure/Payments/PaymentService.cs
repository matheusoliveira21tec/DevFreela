using DevFreela.Core.DTOs;
using DevFreela.Core.Services;
using Microsoft.Extensions.Configuration;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DevFreela.Infrastructure.Payments;

public class PaymentService : IPaymentService
{
    public Task<bool> ProcessPayment(PaymentInfoDTO paymentInfoDTO)
    {
        return Task.FromResult(true);
    }
}
