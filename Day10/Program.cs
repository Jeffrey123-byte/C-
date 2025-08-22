using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Project folder path
        string projectRoot = Directory.GetParent(Directory.GetCurrentDirectory())!.Parent!.Parent!.FullName;
        string outputPath = Path.Combine(projectRoot, "MedicalInformationForm.pdf");

        try
        {
            // Create PDF
            using (var writer = new PdfWriter(outputPath))
            {
                using (var pdf = new PdfDocument(writer))
                {
                    using (var document = new Document(pdf))
                    {
                        // Title
                        Paragraph title = new Paragraph("Medical Information Form")
                            .SetTextAlignment(TextAlignment.CENTER)
                            .SetFontSize(18)
                            .SetBold();
                        document.Add(title);

                        document.Add(new Paragraph("\n")); // spacer

                        // Patient Details Section
                        document.Add(new Paragraph("Patient Details")
                            .SetFontSize(14).SetBold());
                        document.Add(new Paragraph("Name : ________________________________"));
                        document.Add(new Paragraph("Age : _________________________________"));
                        document.Add(new Paragraph("Gender : _________________________________"));
                        document.Add(new Paragraph("\n"));

                        // Medical History Section
                        document.Add(new Paragraph("Medical History")
                            .SetFontSize(14).SetBold());
                        document.Add(new Paragraph("Allergies: ____________________________"));
                        document.Add(new Paragraph("Illnesses: ____________________________"));
                        document.Add(new Paragraph("Surgeries: ____________________________"));
                        document.Add(new Paragraph("\n"));

                        // Emergency Contact + Doctor
                        document.Add(new Paragraph("Emergency Contact")
                            .SetFontSize(14).SetBold());
                        document.Add(new Paragraph("Name : ________________________________"));
                        document.Add(new Paragraph("Phone : _______________________________"));
                        document.Add(new Paragraph("\n"));

                        document.Add(new Paragraph("Doctor’s Information")
                            .SetFontSize(14).SetBold());
                        document.Add(new Paragraph("Doctor Name : _________________________"));
                        document.Add(new Paragraph("Phone : _______________________________"));
                        document.Add(new Paragraph("\n\n"));

                        // Signature Section
                        document.Add(new Paragraph("Signature of Guardian/Doctor : ________________________")
                            .SetFontSize(12).SetBold());

                        document.Add(new Paragraph("\n\nDate : ________________________")
                            .SetFontSize(12));
                    }
                }
            }

            Console.WriteLine($"✅ Medical Information Form PDF created successfully at: {outputPath}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("❌ Error creating PDF:");
            Console.WriteLine(ex.Message);
        }
    }
}
