// Function that returns a Promise which resolves after a given time
function delay(ms) {
  return new Promise((resolve) =>
   {
    setTimeout(resolve, ms);
  });
}

// Function that simulates fetching data from an API
function fetchData() {
  return delay(5000)
  .then(() => {
    // Simulated data
    const data = { id: 1, name: 'Example Data' };
    return data;
  });
}
//===========================
// Using Promises and chaining
fetchData()
  .then((data) => {
    console.log('Data received:', data);
    return 'Processed Data';
  })
  .then((processedData) => {
    console.log('Data processed:', processedData);
  })
  .catch((error) => {
    console.error('Error:', error);
  });

  //=======================
// Using async/await and error handling
async function fetchDataAsync() {
  try {
    const data = await fetchData();
    console.log('Data received (async):', data);
    return 'Processed Data (async)';
  } catch (error) {
    console.error('Error (async):', error);
  }
}

fetchDataAsync()
  .then((processedData) => {
    console.log('Data processed (async):', processedData);
  });
