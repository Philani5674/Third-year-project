using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistrationSystem.baseDataSetTableAdapters;
using RegistrationSystem.Classes;

namespace RegistrationSystem
{
    public class HandleRegistration
    {
        private int _studentId = 0;
        private int _registrationId = 0;
        public object RegisterStudent(
            Student student,
            Guardian guardian,
            IEnumerable<SupportDocument> supportDocuments,
            IEnumerable<RegisteredSubject> registeredSubjects,
            Registration registrationData,
            Payment payment,
            BankDetails bankDetails
        )
        {
            try
            {
                var studentAdapter = new StudentTableAdapter();
                var newStudent = studentAdapter.CreateStudent(
                    IDNumber: student.IDNumber,
                    DateOfBirth: student.DateOfBirth.ToString(CultureInfo.InvariantCulture),
                    HomeAddress: student.Address,
                    PhoneNumber: student.PhoneNumber,
                    Gender: student.Gender,
                    AccountID: student.Account.AccountID);
                _studentId = (int)newStudent;
                // student guardian
                CreateGuardian(guardian);
                // student support docs
                AddSupportDocuments(supportDocuments);
                // subjects picked by student
                RegisterSubjects(registeredSubjects);
                // registration object
                CreateRegistration(registrationData, payment);

                // adds student banking details
                AddBankDetails(bankDetails);
                return newStudent;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        private object CreateGuardian(Guardian guardian)
        {
            var guardianAdapter = new GuardianTableAdapter();
            if (_studentId < 1) return null;
            var studentGuardian = guardianAdapter.CreateGuardian(
                StudentID: _studentId,
                FirstName: guardian.FirstName,
                LastName: guardian.LastName,
                IDNumber:guardian.IDNumber,
                HomeAddress: guardian.Address,
                PhoneNumber: guardian.PhoneNumber
            );
            return studentGuardian;
        }

        private List<int> AddSupportDocuments(IEnumerable<SupportDocument> documents)
        {
            var docAdapter = new SupportingDocumentTableAdapter();
            var supportDocsId = new List<int>();
            if (_studentId < 1) return null;
            foreach (var document in documents)
            {
                var doc = docAdapter.AddDocument(
                    StudentID:_studentId,
                    File: document.File,
                    FileName: document.FileName,
                    IsVerified: document.IsVerified

                );
                supportDocsId.Add((int)doc);
            }

            return supportDocsId;
        }

        private List<string> RegisterSubjects(IEnumerable<RegisteredSubject> subjects)
        {
            var regSubsAdapter = new RegisteredSubjectTableAdapter();
            var regSubsId = new List<string>();
            if (_studentId < 1) return null;
            foreach (var subject in subjects)
            {
                var sub = regSubsAdapter.AddSubject(
                    StudentID: _studentId,
                    SubjectCode: subject.SubjectCode,
                    MatricMark: byte.Parse(subject.MatricMark),
                    UpgradeMark: byte.Parse(subject.UpgradeMark)
                );
                // returns sub codes
                regSubsId.Add((string)sub);
            }
            return regSubsId;
        }

        private object CreateRegistration(Registration registration, Payment payment)
        {
            var processPayment = new PaymentHandler();
            var regAdapter = new RegistrationTableAdapter();
            if (_studentId < 1) return null;
            var reg = regAdapter.AddRegistration(
                StudentID:_studentId,
                PaymentPlanID: registration.PaymentPlanID,
                AdminID: registration.AdminID,
                AmountDue: registration.AmountDue,
                AmountPayed: registration.AmountPayed,
                RegistrationDate: registration.RegistrationDate,
                IsApproved: registration.IsApproved,
                ReasonNotApproved: registration.ReasonNotApproved
            );
            if ((int)reg > 0)
            {
                processPayment.NewPayment(new Payment
                {
                    RegistrationID = (int)reg,
                    PaymentDate = payment.PaymentDate,
                    PaymentDescription = payment.PaymentDescription,
                    Amount = payment.Amount
                });

            }
            return reg;
        }

        //TODO: Continue with Banking details
        private object AddBankDetails(BankDetails bankDetails)
        {
            var bankAdapter = new BankDetailsTableAdapter();
            if (_studentId < 1) return null;
            var bank = bankAdapter.AddBank(
                StudentID: _studentId,
                BankName: bankDetails.BankName,
                CardHolder: bankDetails.CardHolder,
                CardNumber: bankDetails.CardNumber,
                ExpiryDate: bankDetails.ExpiryDate.ToString(),
                Cvc: bankDetails.Cvc
                );
            return bank;
        }
    }
}
