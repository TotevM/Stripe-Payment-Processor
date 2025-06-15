document.addEventListener('DOMContentLoaded', function() {
    const forms = document.querySelectorAll('.add-to-cart-form');
    
    forms.forEach(form => {
        form.addEventListener('submit', async function(e) {
            e.preventDefault();
            
            const productId = form.action.split('/').pop();
            
            try {
                const response = await fetch(form.action, {
                    method: 'POST',
                    headers: {
                        'Content-Type': 'application/json',
                        'RequestVerificationToken': form.querySelector('input[name="__RequestVerificationToken"]').value
                    },
                    body: JSON.stringify({ id: productId })
                });

                if (!response.ok) {
                    throw new Error('Network response was not ok');
                }

                const data = await response.json();
                if (data.success) {
                    const counter = document.getElementById('cartCounter');
                    counter.textContent = data.count;
                    counter.style.display = data.count > 0 ? 'block' : 'none';
                }
            } catch (error) {
                console.error('Error adding to cart:', error);
                alert('Failed to add item to cart. Please try again.');
            }
        });
    });
}); 