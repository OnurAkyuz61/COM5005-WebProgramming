// JavaScript for handling form submission and thank you message functionality

// Variable to track the number of messages sent
let messageCount = 0;

// Wait for the DOM to be fully loaded before executing scripts
document.addEventListener('DOMContentLoaded', function() {
    // Get references to important DOM elements
    const contactForm = document.getElementById('contactForm');
    const thankYouMessage = document.getElementById('thankYouMessage');
    const contactMeSection = document.querySelector('.contact-me');
    const sendAnotherLink = document.getElementById('sendAnotherLink');
    const messageCountSpan = document.getElementById('messageCount');
    const submissionTimeElement = document.getElementById('submissionTime');
    
    // Profile initials are now handled in HTML/CSS, no need for image handling
    
    // Handle form submission
    contactForm.addEventListener('submit', function(e) {
        // Prevent the default form submission behavior
        e.preventDefault();
        
        // Validate required fields
        const firstName = document.getElementById('firstName').value.trim();
        const lastName = document.getElementById('lastName').value.trim();
        const email = document.getElementById('email').value.trim();
        const subject = document.getElementById('subject').value.trim();
        const message = document.getElementById('message').value.trim();
        
        // Check if all required fields are filled with specific alerts
        if (!firstName) {
            alert('Lütfen adınızı giriniz / Please enter your first name');
            document.getElementById('firstName').focus();
            return;
        }
        
        if (!lastName) {
            alert('Lütfen soyadınızı giriniz / Please enter your last name');
            document.getElementById('lastName').focus();
            return;
        }
        
        if (!email) {
            alert('Lütfen e-mail adresinizi giriniz / Please enter your email address');
            document.getElementById('email').focus();
            return;
        }
        
        if (!subject) {
            alert('Lütfen konu başlığını giriniz / Please enter the subject');
            document.getElementById('subject').focus();
            return;
        }
        
        if (!message) {
            alert('Lütfen mesajınızı giriniz / Please enter your message');
            document.getElementById('message').focus();
            return;
        }
        
        // Validate email format
        const emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
        if (!emailRegex.test(email)) {
            alert('Please enter a valid email address.');
            return;
        }
        
        // Increment message count
        messageCount++;
        
        // Get current date and time for submission timestamp
        const now = new Date();
        const options = {
            weekday: 'short',
            year: 'numeric',
            month: 'short',
            day: '2-digit',
            hour: '2-digit',
            minute: '2-digit',
            second: '2-digit',
            timeZoneName: 'short'
        };
        
        // Format the submission time as shown in the image
        const formattedTime = now.toLocaleDateString('en-US', options);
        const timeString = `${formattedTime} GMT+0300 (GMT+03:00)`;
        
        // Update the thank you message with submission details
        messageCountSpan.textContent = messageCount;
        submissionTimeElement.textContent = timeString;
        
        // Hide the contact form and show the thank you message
        contactMeSection.style.display = 'none';
        thankYouMessage.style.display = 'block';
        
        // Scroll to the thank you message for better user experience
        thankYouMessage.scrollIntoView({ behavior: 'smooth' });
        
        // Log form submission for debugging purposes
        console.log('Form submitted successfully:', {
            firstName,
            lastName,
            email,
            subject,
            message,
            submissionTime: timeString,
            messageCount
        });
    });
    
    // Handle "click here" link to send another message
    sendAnotherLink.addEventListener('click', function(e) {
        // Prevent default link behavior
        e.preventDefault();
        
        // Reset the form fields
        contactForm.reset();
        
        // Hide thank you message and show contact form again
        thankYouMessage.style.display = 'none';
        contactMeSection.style.display = 'block';
        
        // Scroll back to the contact form
        contactMeSection.scrollIntoView({ behavior: 'smooth' });
        
        // Focus on the first input field for better user experience
        document.getElementById('firstName').focus();
    });
    
    // Add smooth scrolling for navigation links
    const navLinks = document.querySelectorAll('.nav-link');
    navLinks.forEach(link => {
        link.addEventListener('click', function(e) {
            // Prevent default behavior for demo purposes
            e.preventDefault();
            
            // Add visual feedback for link clicks
            this.style.backgroundColor = '#d0d0d0';
            setTimeout(() => {
                this.style.backgroundColor = '';
            }, 200);
            
            // Log navigation click for debugging
            console.log('Navigation link clicked:', this.textContent);
        });
    });
    
    // Add form field validation feedback
    const requiredFields = ['firstName', 'lastName', 'email', 'subject', 'message'];
    requiredFields.forEach(fieldId => {
        const field = document.getElementById(fieldId);
        if (field) {
            // Add real-time validation feedback
            field.addEventListener('blur', function() {
                if (this.value.trim() === '') {
                    this.style.borderColor = '#dc3545';
                } else {
                    this.style.borderColor = '#28a745';
                }
            });
            
            // Remove validation styling when user starts typing
            field.addEventListener('input', function() {
                this.style.borderColor = '#ccc';
            });
        }
    });
    
    // Email field specific validation
    const emailField = document.getElementById('email');
    if (emailField) {
        emailField.addEventListener('blur', function() {
            const emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
            if (this.value.trim() !== '' && !emailRegex.test(this.value)) {
                this.style.borderColor = '#dc3545';
            } else if (this.value.trim() !== '') {
                this.style.borderColor = '#28a745';
            }
        });
    }
    
    // Add keyboard navigation support
    document.addEventListener('keydown', function(e) {
        // Allow Escape key to close thank you message and return to form
        if (e.key === 'Escape' && thankYouMessage.style.display === 'block') {
            sendAnotherLink.click();
        }
    });
    
    // Initialize form with focus on first field
    document.getElementById('firstName').focus();
    
    // Add scroll behavior for left sidebar
    const leftSidebar = document.querySelector('.left-sidebar');
    const header = document.querySelector('.header');
    
    if (leftSidebar && header) {
        let initialSidebarTop = 280; // Initial top position - starts from white content area
        
        window.addEventListener('scroll', function() {
            const scrollTop = window.pageYOffset || document.documentElement.scrollTop;
            const headerHeight = header.offsetHeight;
            const footer = document.querySelector('.footer');
            const centerContent = document.querySelector('.center-content');
            
            // Calculate boundaries
            const minTop = headerHeight + 10; // Don't go above content area
            
            // Calculate maximum top position to keep sidebar visible and not in footer
            let maxTop = initialSidebarTop;
            if (footer && centerContent) {
                const footerTop = footer.offsetTop;
                const sidebarHeight = leftSidebar.offsetHeight;
                const centerContentBottom = centerContent.offsetTop + centerContent.offsetHeight;
                
                // Keep sidebar well above footer - use the end of center content as boundary
                maxTop = Math.min(footerTop - sidebarHeight - 50, centerContentBottom - sidebarHeight - 30);
            }
            
            // Calculate new position - sidebar should move down slowly with scroll
            let newTop = initialSidebarTop + (scrollTop * 0.3); // Slower movement
            
            // Apply boundaries
            newTop = Math.max(minTop, Math.min(newTop, maxTop));
            
            leftSidebar.style.top = newTop + 'px';
        });
    }
    
    // Log that JavaScript has loaded successfully
    console.log('Personal webpage JavaScript loaded successfully');
});
