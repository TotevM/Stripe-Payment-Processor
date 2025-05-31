document.addEventListener('DOMContentLoaded', function() {
    const quantityButtons = document.querySelectorAll('.quantity-btn');
    
    quantityButtons.forEach(button => {
        button.addEventListener('click', async function() {
            const action = this.dataset.action;
            const productId = this.dataset.productId;
            const quantityDisplay = document.querySelector(`.quantity-display[data-product-id="${productId}"]`);
            let currentQuantity = parseInt(quantityDisplay.textContent);
            
            if (action === 'increase') {
                currentQuantity++;
            } else if (action === 'decrease') {
                if (currentQuantity > 1) {
                    currentQuantity--;
                } else {
                    return;
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
                    quantityDisplay.textContent = currentQuantity;
                    
                    document.getElementById('subtotal').textContent = data.subtotal;
                    document.getElementById('tax').textContent = data.tax;
                    document.getElementById('total').textContent = data.total;
                }
            } catch (error) {
                console.error('Error updating quantity:', error);
                alert('Failed to update quantity. Please try again.');
            }
        });
    });
})