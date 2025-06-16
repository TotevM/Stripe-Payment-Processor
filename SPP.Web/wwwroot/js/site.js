// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// Function to update cart counter
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

document.addEventListener('DOMContentLoaded', updateCartCounter);
