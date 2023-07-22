function updateQueryString(key, value) {
    const urlParams = new URLSearchParams(window.location.search);
    urlParams.set(key, value);
    const newUrl = window.location.pathname + '?' + urlParams.toString();
    window.history.pushState({ path: newUrl }, '', newUrl);

    // Set the value of the hidden field
    document.getElementById('last-selected-tab').value = value;
}