document.getElementById('download-resume').addEventListener('click', function () {
    const link = document.createElement('a');
    link.href = '~/docs/Chase_McClellan_Resume.pdf';  // Ensure this path points to the correct location of the file in your project
    link.download = 'Chase_McClellan_Resume.pdf';  // This is the name the file will be saved as
    document.body.appendChild(link);
    link.click();
    document.body.removeChild(link);
});
