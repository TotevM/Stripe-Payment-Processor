document.addEventListener('DOMContentLoaded', function() {
    const datePickers = flatpickr(".datepicker", {
        dateFormat: "Y-m-d",
        maxDate: "today",
        allowInput: true
    });

    const fromDateInput = document.getElementById('fromDate');
    const toDateInput = document.getElementById('toDate');
    const applyDateFilterBtn = document.getElementById('applyDateFilter');
    const priceFilters = document.querySelectorAll('.price-filter');
    const orderCards = document.querySelectorAll('.order-card');
    const ordersContainer = document.getElementById('ordersContainer');

    const originalOrderCards = Array.from(orderCards);

    function isDateInRange(date, fromDate, toDate) {
        if (!fromDate && !toDate) return true;
        
        const orderDate = new Date(date);
        const from = fromDate ? new Date(fromDate) : null;
        const to = toDate ? new Date(toDate) : null;

        if (from && to) {
            return orderDate >= from && orderDate <= to;
        } else if (from) {
            return orderDate >= from;
        } else if (to) {
            return orderDate <= to;
        }
        return true;
    }
    function isPriceInRange(price, selectedRanges) {
        if (selectedRanges.length === 0) return true;

        return selectedRanges.some(range => {
            switch(range) {
                case 'under500':
                    return price < 500;
                case '500to1000':
                    return price >= 500 && price <= 1000;
                case 'over1000':
                    return price > 1000;
                default:
                    return true;
            }
        });
    }

    function applyFilters() {
        const fromDate = fromDateInput.value;
        const toDate = toDateInput.value;
        const selectedPriceRanges = Array.from(priceFilters)
            .filter(checkbox => checkbox.checked)
            .map(checkbox => checkbox.value);

        ordersContainer.innerHTML = '';

        const filteredOrders = originalOrderCards.filter(card => {
            const orderDate = card.dataset.orderDate;
            const orderTotal = parseFloat(card.dataset.orderTotal);

            const dateMatch = isDateInRange(orderDate, fromDate, toDate);
            const priceMatch = isPriceInRange(orderTotal, selectedPriceRanges);

            return dateMatch && priceMatch;
        });

        if (filteredOrders.length === 0) {
            ordersContainer.innerHTML = `
                <div class="text-center py-5">
                    <i class="bi bi-search fs-1 text-muted mb-3"></i>
                    <h3 class="text-muted">No orders found</h3>
                    <p class="text-muted">Try adjusting your filters</p>
                </div>
            `;
        } else {
            filteredOrders.forEach(card => {
                ordersContainer.appendChild(card.cloneNode(true));
            });
        }
    }

    applyDateFilterBtn.addEventListener('click', applyFilters);

    priceFilters.forEach(checkbox => {
        checkbox.addEventListener('change', function() {
            if (this.checked) {
                priceFilters.forEach(otherCheckbox => {
                    if (otherCheckbox !== this) {
                        otherCheckbox.checked = false;
                    }
                });
            }
            applyFilters();
        });
    });

    const filterCards = document.querySelectorAll('.card.shadow-sm');
    filterCards.forEach(card => {
        const clearButton = document.createElement('button');
        clearButton.className = 'btn btn-outline-secondary btn-sm mt-2';
        clearButton.textContent = 'Clear Filter';
        clearButton.addEventListener('click', function() {
            if (card.querySelector('.datepicker')) {
                fromDateInput.value = '';
                toDateInput.value = '';
                datePickers.forEach(picker => picker.clear());
            } else {
                priceFilters.forEach(checkbox => checkbox.checked = false);
            }
            applyFilters();
        });
        card.querySelector('.card-body').appendChild(clearButton);
    });
}); 