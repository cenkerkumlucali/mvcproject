using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules_Fluent_Validation
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar Adını Boş Geçemezsiniz.");
            RuleFor(x => x.WriterSurname ).NotEmpty().WithMessage("Yazar Soy Adını Boş Geçemezsiniz.");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre Boş Geçilemez.");
            RuleFor(x => x.WriterMail).EmailAddress().WithMessage("Mail Adresiniz example@example.com Şeklinde Olmalıdır.");
            RuleFor(x => x.WriterPassword).MinimumLength(3).WithMessage("Şifre En Az 3 Karakter Olmalıdır.");
            RuleFor(x => x.WriterName).MinimumLength(3).WithMessage("İsim En Az 3 Karakter Olmalıdır.");
            RuleFor(x => x.WriterSurname).MinimumLength(3).WithMessage("Soy İsim En Az 3 Karakter Olmalıdır.");

        }
    }
}
