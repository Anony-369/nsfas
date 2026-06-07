Option Explicit On
Option Strict On

Public Class Form1
    Private Const PRICE_SMARTPHONE As Decimal = 4000D
    Private Const PRICE_LAPTOP As Decimal = 7000D
    Private Const PRICE_TABLET As Decimal = 5000D
    Private Const PRICE_EARPHONES As Decimal = 200D
    Private Const PRICE_CHARGER As Decimal = 350D
    Private Const PRICE_MOUSE As Decimal = 500D
    Private Const PRICE_KEYBOARD As Decimal = 600D
    Private Const VAT_RATE As Decimal = 0.15D

    Private Sub btnShowPromo_Click(sender As Object, e As EventArgs) Handles btnShowPromo.Click
        ' Validate customer fields
        If String.IsNullOrWhiteSpace(txtName.Text) OrElse _
           String.IsNullOrWhiteSpace(txtSurname.Text) OrElse _
           String.IsNullOrWhiteSpace(txtCellNumber.Text) OrElse _
           String.IsNullOrWhiteSpace(txtEmail.Text) Then
            MessageBox.Show("Please complete all customer details.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Determine main product selection
        Dim mainProduct As String = String.Empty
        Dim totalA As Decimal = 0D

        If rbtnSmartphone.Checked Then
            mainProduct = "Smartphone"
            totalA = PRICE_SMARTPHONE
        ElseIf rbtnLaptop.Checked Then
            mainProduct = "Laptop"
            totalA = PRICE_LAPTOP
        ElseIf rbtnTablet.Checked Then
            mainProduct = "Tablet"
            totalA = PRICE_TABLET
        Else
            MessageBox.Show("Please select a main product.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Calculate accessory totals
        Dim accessoryItems As New List(Of String)()
        Dim totalB As Decimal = 0D

        If chkEarphones.Checked Then
            accessoryItems.Add("Earphones")
            totalB += PRICE_EARPHONES
        End If
        If chkCharger.Checked Then
            accessoryItems.Add("Charger")
            totalB += PRICE_CHARGER
        End If
        If chkMouse.Checked Then
            accessoryItems.Add("Mouse")
            totalB += PRICE_MOUSE
        End If
        If chkKeyboard.Checked Then
            accessoryItems.Add("Keyboard")
            totalB += PRICE_KEYBOARD
        End If

        ' Apply promotions
        Dim discountEarphones As Decimal = 0D
        Dim discountKeyboard As Decimal = 0D

        If rbtnSmartphone.Checked AndAlso chkEarphones.Checked Then
            discountEarphones = PRICE_EARPHONES * 0.1D
        End If

        If rbtnLaptop.Checked AndAlso chkKeyboard.Checked Then
            discountKeyboard = 100D
        End If

        Dim totalDiscount As Decimal = discountEarphones + discountKeyboard
        Dim subtotal As Decimal = totalA + totalB - totalDiscount
        Dim vatAmount As Decimal = subtotal * VAT_RATE
        Dim finalTotal As Decimal = subtotal + vatAmount

        ' Display formatted receipt
        lstReceipt.Items.Clear()
        lstReceipt.Items.Add($"Date: {DateTime.Now:dd MMMM yyyy}")
        lstReceipt.Items.Add($"Time: {DateTime.Now:hh:mm tt}")
        lstReceipt.Items.Add(String.Empty)
        lstReceipt.Items.Add($"Name: {txtName.Text.Trim()}")
        lstReceipt.Items.Add($"Surname: {txtSurname.Text.Trim()}")
        lstReceipt.Items.Add($"Cell Number: {txtCellNumber.Text.Trim()}")
        lstReceipt.Items.Add($"Email: {txtEmail.Text.Trim()}")
        lstReceipt.Items.Add(String.Empty)
        lstReceipt.Items.Add("Order Summary:")
        lstReceipt.Items.Add($"  Main Product: {mainProduct} - R{totalA:N2}")

        If accessoryItems.Count > 0 Then
            lstReceipt.Items.Add($"  Accessories: {String.Join(", ", accessoryItems)} - R{totalB:N2}")
        Else
            lstReceipt.Items.Add("  Accessories: None - R0.00")
        End If

        lstReceipt.Items.Add(String.Empty)
        lstReceipt.Items.Add("Discounts:")
        lstReceipt.Items.Add($"  Earphones discount: R{discountEarphones:N2}")
        lstReceipt.Items.Add($"  Keyboard discount: R{discountKeyboard:N2}")
        lstReceipt.Items.Add(String.Empty)
        lstReceipt.Items.Add($"Subtotal: R{subtotal:N2}")
        lstReceipt.Items.Add($"VAT (15%): R{vatAmount:N2}")
        lstReceipt.Items.Add($"Total: R{finalTotal:N2}")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtName.Clear()
        txtSurname.Clear()
        txtCellNumber.Clear()
        txtEmail.Clear()

        rbtnSmartphone.Checked = False
        rbtnLaptop.Checked = False
        rbtnTablet.Checked = False

        chkEarphones.Checked = False
        chkCharger.Checked = False
        chkMouse.Checked = False
        chkKeyboard.Checked = False

        lstReceipt.Items.Clear()
        txtName.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim result = MessageBox.Show("Do you want to exit the application?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub txtCellNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCellNumber.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class
