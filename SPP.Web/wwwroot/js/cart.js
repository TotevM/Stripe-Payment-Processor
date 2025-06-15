document.addEventListener('DOMContentLoaded', function() {
    const quantityButtons = document.querySelectorAll('.quantity-btn');
    const deleteButtons = document.querySelectorAll('.del-btn');

    async function updateCartCounter() {
        try {
            const response = await fetch('/Cart/GetItemCount');
            if (response.ok) {
                const count = await response.json();
                const counter = document.getElementById('cartCounter');
                counter.textContent = count;
                counter.style.display = count > 0 ? 'block' : 'none';
            }
        } catch (error) {
            console.error('Error updating cart counter:', error);
        }
    }

    deleteButtons.forEach(button => {
        button.addEventListener('click', async function () {

            const productId = this.dataset.productId;
            const response = await fetch('/Cart/UpdateQuantity', {
                method: 'POST',
                headers: {
                    'Content-Type': 'application/json',
                    'RequestVerificationToken': document.querySelector('input[name="__RequestVerificationToken"]').value
                },
                body: JSON.stringify({
                    id: productId,
                    quantity: 0
                })
            });

            if (!response.ok) {
                throw new Error('Network response was not ok');
            }

            const remainingProducts = document.querySelectorAll('.cart-item');
            if (remainingProducts.length === 1) {
                window.location.href = '/Cart';
            } else {
            const data = await response.json();

            if (data.success) {
                document.getElementById('subtotal').textContent = data.subtotal;
                document.getElementById('tax').textContent = data.tax;
                document.getElementById('total').textContent = data.total;
                await updateCartCounter();
            }

            const product = this.closest('.cart-item');
            product.remove();
            }

        })
    })

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
                    await updateCartCounter();
                }
            } catch (error) {
                console.error('Error updating quantity:', error);
                alert('Failed to update quantity. Please try again.');
            }
        });
    });
})