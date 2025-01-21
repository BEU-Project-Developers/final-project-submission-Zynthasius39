using BankingApp.Models;
using BankingApp.Models.Enums;
using System.Drawing.Drawing2D;

namespace BankingApp.UI
{
    internal static class FormHelpers
    {
        public const string PATH = @"..\..\..\Assets";

        private static readonly List<Bitmap> images =
        [
            new Bitmap(PATH + @"\credit.png"),
            new Bitmap(PATH + @"\debit.png"),
            new Bitmap(PATH + @"\investing.png"),
            new Bitmap(PATH + @"\savings.png"),
        ];

        public static Customer? CurrentUser;
        public static List<Account>? UserAccounts;
        public static List<Contract>? UserContracts;
        public static List<Transaction>? UserTransactions;

        public static List<Payment>? Payments;

        // Offline User
        public static readonly Customer OfflineUser = new()
        {
            Id = 256,
            Email = "",
            Name = "Vüqar",
            Surname = "Cəbiyev",
            Password = "e3b0c44298fc1c149afbf4c8996fb92427ae41e4649b934ca495991b7852b855",
            Phone = "0556667788",
            Role = Models.Enums.Rolet.Business,
            RegisterDate = DateTime.Now,
            TransactionIDs = []
        };

        // Offline Mod User
        public static readonly Customer OfflineModUser = new()
        {
            Id = 256,
            Email = "mod@home.alak",
            Name = "Moderator",
            Surname = "",
            Password = "e3b0c44298fc1c149afbf4c8996fb92427ae41e4649b934ca495991b7852b855",
            Phone = "0556667788",
            Role = Models.Enums.Rolet.Mod,
            RegisterDate = DateTime.Now,
            TransactionIDs = []
        };
        public static readonly int BorderRadius = 30;

        public static string SeparateBy(string str, int chunkSize)
        {
            char[] reversed = str.ToCharArray();
            Array.Reverse(reversed);
            string reversedString = new(reversed);

            string separated = string.Join(" ", SplitIntoChunks(reversedString, chunkSize));

            char[] finalReversed = separated.ToCharArray();
            Array.Reverse(finalReversed);

            return new string(finalReversed);
        }

        public static string[] SplitIntoChunks(string str, int chunkSize)
        {
            int length = (str.Length + chunkSize - 1) / chunkSize;
            string[] chunks = new string[length];

            for (int i = 0; i < length; i++)
            {
                int start = i * chunkSize;
                chunks[i] = str.Substring(start, Math.Min(chunkSize, str.Length - start));
            }

            return chunks;
        }

        public static GraphicsPath CreateRoundedRectanglePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new();
            path.AddArc(rect.Left, rect.Top, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Top, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.Left, rect.Bottom - radius, radius, radius, 90, 90);
            path.CloseFigure();
            return path;
        }

        public static Control AddAccount(Account account)
        {
            var container = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = AppSkinHelper.msm.BackgroundFocusColor,
                Margin = new Padding(10),
                Padding = new Padding(10),
                TabStop = false,
            };
            var icon = new PictureBox
            {
                Size = new Size(260, 156),
                BackColor = Color.Transparent,
                SizeMode = PictureBoxSizeMode.StretchImage,
                TabStop = false,
                Parent = container,
            };
            if (account.AccountType == Accountt.Credit)
                icon.Image = images[0];
            else if (account.AccountType == Accountt.Debit)
                icon.Image = images[1];
            else if (account.AccountType == Accountt.Investing)
                icon.Image = images[2];
            else if (account.AccountType == Accountt.Savings)
                icon.Image = images[3];
            var label = new Label
            {
                AutoSize = true,
                Font = new Font("Kredit Back", 24F, FontStyle.Regular, GraphicsUnit.Pixel),
                BackColor = Color.Transparent,
                ForeColor = Color.Gold,
                Text = FormHelpers.SeparateBy(account.AccountNumber.ToString(), 4),
                Parent = icon,
            };
            var expr_label = new Label
            {
                Location = new Point(20, 100),
                AutoSize = true,
                Font = new Font("Noto Sans", 24F, FontStyle.Regular, GraphicsUnit.Pixel),
                BackColor = Color.Transparent,
                ForeColor = AppSkinHelper.msm.ColorScheme.TextColor,
                Text = account.ExpirationDate.ToString("MMMM dd, yyyy"),
                Parent = container,
            };
            var info = new Label
            {
                Location = new Point(20, 20),
                AutoSize = true,
                Font = new Font("Noto Sans", 36F, FontStyle.Bold, GraphicsUnit.Pixel),
                BackColor = Color.Transparent,
                ForeColor = AppSkinHelper.msm.ColorScheme.TextColor,
                Text = account.Amount.ToString() + " " + account.Currency.ToDescription(),
                Parent = container,
            };
            icon.Region = new Region(FormHelpers.CreateRoundedRectanglePath(icon.ClientRectangle, BorderRadius));
            container.MouseEnter += (sender, args) => { container.BackColor = AppSkinHelper.msm.BackgroundHoverColor; };
            icon.MouseEnter += (sender, args) => { container.BackColor = AppSkinHelper.msm.BackgroundHoverColor; };
            info.MouseEnter += (sender, args) => { container.BackColor = AppSkinHelper.msm.BackgroundHoverColor; };
            expr_label.MouseEnter += (sender, args) => { container.BackColor = AppSkinHelper.msm.BackgroundHoverColor; };
            label.MouseEnter += (sender, args) => { container.BackColor = AppSkinHelper.msm.BackgroundHoverColor; };
            container.MouseLeave += (sender, args) => { container.BackColor = AppSkinHelper.msm.BackgroundFocusColor; };
            container.SizeChanged += (sender, args) =>
            {
                label.Location = new Point((icon.Size.Width - label.Size.Width) / 2, (int)(icon.Size.Height * 0.55));
                icon.Location = new Point(container.Size.Width - 260 - 20, (container.Size.Height - 156) / 2);
                container.Region = new Region(FormHelpers.CreateRoundedRectanglePath(container.ClientRectangle, BorderRadius));
            };
            container.Click += (sender, e) =>
            {
                CardBox cb = new(account);
                cb.ShowDialog();
            };
            return container;
        }

        public static Control AddPayment(Payment payment)
        {
            var container = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = AppSkinHelper.msm.BackgroundFocusColor,
                ForeColor = Color.FromArgb(222, 0, 0, 0),
                Margin = new Padding(10),
                Padding = new Padding(10),
                TabStop = false,
            };
            var icon = new PictureBox
            {
                BackColor = Color.Transparent,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Image = payment.Image,
                Size = new Size(50, 50),
                TabStop = false,
                Parent = container,
            };
            if (icon.Image != null)
            {
                icon.Size = new Size(50, (icon.Image.Height * 50) / icon.Image.Width);
            }
            var label = new Label
            {
                AutoSize = true,
                Font = new Font("Roboto", 28F, FontStyle.Regular, GraphicsUnit.Pixel),
                BackColor = Color.Transparent,
                ForeColor = AppSkinHelper.msm.ColorScheme.TextColor,
                Location = new Point(20, 20),
                Size = new Size(145, 41),
                Text = payment.Name,
                Parent = container,
            };
            var amount = new Label
            {
                AutoSize = true,
                Font = new Font("Roboto", 28F, FontStyle.Regular, GraphicsUnit.Pixel),
                BackColor = Color.Transparent,
                ForeColor = AppSkinHelper.msm.ColorScheme.TextColor,
                Size = new Size(145, 41),
                Text = $"{payment.Amount} {payment.Currency.ToDescription()}",
                Parent = container,
            };
            container.MouseEnter += (sender, args) => { container.BackColor = AppSkinHelper.msm.BackgroundHoverColor; };
            icon.MouseEnter += (sender, args) => { container.BackColor = AppSkinHelper.msm.BackgroundHoverColor; };
            label.MouseEnter += (sender, args) => { container.BackColor = AppSkinHelper.msm.BackgroundHoverColor; };
            container.MouseLeave += (sender, args) => { container.BackColor = AppSkinHelper.msm.BackgroundFocusColor; };
            container.SizeChanged += (sender, args) =>
            {
                icon.Location = new Point(20, (container.Size.Height - icon.Size.Height) / 2);
                amount.Location = new Point(container.Size.Width - amount.Size.Width - 20, (container.Size.Height - amount.Size.Height) / 2);
                label.Location = new Point(icon.Size.Width + 40, (container.Size.Height - label.Height) / 2);
                container.Region = new Region(FormHelpers.CreateRoundedRectanglePath(container.ClientRectangle, BorderRadius));
            };
            container.Click += (sender, e) =>
            {
                PaymentBox pb = new(payment);
                pb.ShowDialog();
            };
            return container;
        }

        public static Control AddTransaction(Transaction transaction)
        {
            var container = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = AppSkinHelper.msm.BackgroundFocusColor,
                Margin = new Padding(10),
                Padding = new Padding(10),
                TabStop = false,
            };
            var icon = new PictureBox
            {
                Size = new Size(25, 25),
                BackColor = Color.Transparent,
                SizeMode = PictureBoxSizeMode.StretchImage,
                TabStop = false,
                Parent = container,
            };
            var label = new Label
            {
                AutoSize = true,
                Font = new Font("Roboto", 18F, FontStyle.Bold, GraphicsUnit.Pixel),
                BackColor = Color.Transparent,
                ForeColor = AppSkinHelper.msm.ColorScheme.TextColor,
                Size = new Size(145, 41),
                Text = transaction.Amount + " " + transaction.Currency.ToDescription(),
                Parent = container,
            };
            var labelDate = new Label
            {
                AutoSize = true,
                Font = new Font("Roboto", 18F, FontStyle.Regular, GraphicsUnit.Pixel),
                BackColor = Color.Transparent,
                ForeColor = AppSkinHelper.msm.ColorScheme.TextColor,
                Size = new Size(145, 41),
                Text = transaction.Date.ToString(),
                Parent = container,
            };
            if (transaction.TransactionType == Models.Enums.Transactiont.Withdrawal) icon.Image = Properties.Resources.withdraw;
            else if (transaction.TransactionType == Models.Enums.Transactiont.Deposit) icon.Image = Properties.Resources.deposit;
            else icon.Image = Properties.Resources.exchange;
            container.MouseEnter += (sender, args) => { container.BackColor = AppSkinHelper.msm.BackgroundHoverColor; };
            label.MouseEnter += (sender, args) => { container.BackColor = AppSkinHelper.msm.BackgroundHoverColor; };
            labelDate.MouseEnter += (sender, args) => { container.BackColor = AppSkinHelper.msm.BackgroundHoverColor; };
            container.MouseLeave += (sender, args) => { container.BackColor = AppSkinHelper.msm.BackgroundFocusColor; };
            container.SizeChanged += (sender, args) =>
            {
                icon.Location = new Point(20, (container.Size.Height - icon.Size.Height) / 2);
                label.Location = new Point(icon.Size.Width + 40, (container.Size.Height - label.Height) / 2);
                labelDate.Location = new Point(container.Size.Width - labelDate.Size.Width - 20, (container.Size.Height - label.Height) / 2);
                container.Region = new Region(FormHelpers.CreateRoundedRectanglePath(container.ClientRectangle, BorderRadius));
            };
            return container;
        }
    }
}
