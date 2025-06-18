function openProductModal(productId, productName, imageUrl, description) {
    document.getElementById('productModalLabel').textContent = productName;
    document.getElementById('modalProductImage').src = imageUrl;
    document.getElementById('modalProductImage').alt = productName;
    document.getElementById('modalProductDescription').textContent = description || 'No description available.';
    
    // Set up modal Add to Cart button
    const modalAddToCartBtn = document.getElementById('modalAddToCartBtn');
    modalAddToCartBtn.onclick = function() {
        addToCartFromModal(productId);
    };
    
    const modal = new bootstrap.Modal(document.getElementById('productModal'));
    modal.show();
}

function addToCartFromModal(productId) {
    const button = document.getElementById('modalAddToCartBtn');
    const originalText = button.innerHTML;
    
    button.innerHTML = '<i class="fas fa-spinner fa-spin me-2"></i>Adding...';
    button.disabled = true;
    
    const formData = new FormData();
    formData.append('id', productId);
    
    const token = document.querySelector('input[name="__RequestVerificationToken"]').value;
    formData.append('__RequestVerificationToken', token);
    
    fetch(`/Product/AddToCart/${productId}`, {
        method: 'POST',
        body: formData,
        headers: {
            'RequestVerificationToken': token
        }
    })
    .then(response => {
        if (response.redirected) {
            window.location.href = response.url;
            return;
        }
        
        if (response.status === 401) {
            window.location.href = '/Identity/Account/Login';
            return;
        }
        
        if (response.ok) {
            button.innerHTML = '<i class="fas fa-check me-2"></i>Added!';
            button.classList.remove('btn-primary');
            button.classList.add('btn-success');
            
            updateCartCounter();
            
            setTimeout(() => {
                button.innerHTML = originalText;
                button.classList.remove('btn-success');
                button.classList.add('btn-primary');
                button.disabled = false;
            }, 2000);
        } else {
            throw new Error('Failed to add to cart');
        }
    })
    .catch(error => {
        console.error('Error:', error);
        button.innerHTML = '<i class="fas fa-times me-2"></i>Error';
        button.classList.remove('btn-primary');
        button.classList.add('btn-danger');
        
        setTimeout(() => {
            button.innerHTML = originalText;
            button.classList.remove('btn-danger');
            button.classList.add('btn-primary');
            button.disabled = false;
        }, 2000);
    });
}

document.addEventListener('DOMContentLoaded', function() {
    const addToCartForms = document.querySelectorAll('.add-to-cart-form');
    
    addToCartForms.forEach(form => {
        form.addEventListener('submit', function(e) {
            e.preventDefault();
            
            const formData = new FormData(form);
            const button = form.querySelector('button[type="submit"]');
            const originalText = button.innerHTML;
            
            button.innerHTML = '<i class="fas fa-spinner fa-spin me-1"></i>Adding...';
            button.disabled = true;
            
            fetch(form.action, {
                method: 'POST',
                body: formData,
                headers: {
                    'RequestVerificationToken': formData.get('__RequestVerificationToken')
                }
            })
            .then(response => {
                if (response.redirected) {
                    // Redirect to login page
                    window.location.href = response.url;
                    return;
                }
                
                if (response.status === 401) {
                    // Unauthorized - redirect to login
                    window.location.href = '/Identity/Account/Login';
                    return;
                }
                
                if (response.ok) {
                    button.innerHTML = '<i class="fas fa-check me-1"></i>Added!';
                    button.classList.remove('btn-primary');
                    button.classList.add('btn-success');
                    
                    updateCartCounter();
                    
                    setTimeout(() => {
                        button.innerHTML = originalText;
                        button.classList.remove('btn-success');
                        button.classList.add('btn-primary');
                        button.disabled = false;
                    }, 2000);
                } else {
                    throw new Error('Failed to add to cart');
                }
            })
            .catch(error => {
                console.error('Error:', error);
                button.innerHTML = '<i class="fas fa-times me-1"></i>Error';
                button.classList.remove('btn-primary');
                button.classList.add('btn-danger');
                
                setTimeout(() => {
                    button.innerHTML = originalText;
                    button.classList.remove('btn-danger');
                    button.classList.add('btn-primary');
                    button.disabled = false;
                }, 2000);
            });
        });
    });
}); 