document.addEventListener('DOMContentLoaded', function() {
    const quantityButtons = document.querySelectorAll('.quantity-btn');
    
    quantityButtons.forEach(button => {
        button.addEventListener('click', async function() {
            const action = this.dataset.action;
            const productId = this.dataset.productId;
            const quantityDisplay = document.querySelector(`.quantity-display[data-product-id="${productId}"]`);
            let currentQuantity = parseInt(quantityDisplay.textContent);
            
            // Update quantity based on action
            if (action === 'increase') {
                currentQuantity++;
            } else if (action === 'decrease') {
                if (currentQuantity > 1) {
                    currentQuantity--;
                } else {
                    return; // Don't allow quantity less than 1
                }
            }
            
            try {
                const response = await fetch('/Cart/UpdateQuantity', {
                    method: 'POST',
                    headers: {
                        'Content-Type': 'application/json',
                        'RequestVerificationToken': document.querySelector('input[name="__RequestVerificationToken"]').value
                    },
                    body: JSON.stringify({
                        id: productId,
                        quantity: currentQuantity
                    })
                });
                
                if (!response.ok) {
                    throw new Error('Network response was not ok');
                }
                
                const data = await response.json();
                
                if (data.success) {
                    // Update quantity display
                    quantityDisplay.textContent = currentQuantity;
                    
                    // Update totals
                    document.getElementById('subtotal').textContent = data.subtotal;
                    document.getElementById('tax').textContent = data.tax.ToSting(2);
                    document.getElementById('total').textContent = data.total.ToSting(2);
                }
            } catch (error) {
                console.error('Error updating quantity:', error);
                alert('Failed to update quantity. Please try again.');
            }
        });
    });
}); 