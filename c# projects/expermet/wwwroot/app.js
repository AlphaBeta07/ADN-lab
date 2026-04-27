const studentRows = document.getElementById('studentRows');
const messageElement = document.getElementById('message');

function showMessage(text, type = 'error') {
    messageElement.textContent = text;
    messageElement.style.color = type === 'success' ? 'green' : 'red';
}

function renderStudents(students) {
    studentRows.innerHTML = '';
    if (students.length === 0) {
        studentRows.innerHTML = '<tr><td colspan="5">No students found.</td></tr>';
        return;
    }

    students.forEach(student => {
        const row = document.createElement('tr');
        row.innerHTML = `
            <td>${student.id}</td>
            <td>${student.name}</td>
            <td>${student.age}</td>
            <td>${student.course}</td>
            <td><button onclick="deleteStudent(${student.id})">Delete</button></td>
        `;
        studentRows.appendChild(row);
    });
}

async function loadStudents() {
    try {
        const response = await fetch('/api/students');
        const students = await response.json();
        renderStudents(students);
        showMessage('Student list loaded.', 'success');
    } catch (error) {
        showMessage('Unable to load students.');
    }
}

async function addStudent() {
    const student = {
        id: Number(document.getElementById('addId').value),
        name: document.getElementById('addName').value.trim(),
        age: Number(document.getElementById('addAge').value),
        course: document.getElementById('addCourse').value.trim(),
    };

    if (!student.id || !student.name || !student.age || !student.course) {
        showMessage('Please fill all fields.');
        return;
    }

    try {
        const response = await fetch('/api/students', {
            method: 'POST',
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify(student),
        });

        if (!response.ok) {
            const data = await response.json();
            throw new Error(data?.message || 'Could not add student.');
        }

        document.getElementById('addId').value = '';
        document.getElementById('addName').value = '';
        document.getElementById('addAge').value = '';
        document.getElementById('addCourse').value = '';
        await loadStudents();
        showMessage('Student added successfully.', 'success');
    } catch (error) {
        showMessage(error.message);
    }
}

async function updateStudent() {
    const id = Number(document.getElementById('updateId').value);
    const student = {
        id,
        name: document.getElementById('updateName').value.trim(),
        age: Number(document.getElementById('updateAge').value),
        course: document.getElementById('updateCourse').value.trim(),
    };

    if (!id || !student.name || !student.age || !student.course) {
        showMessage('Please fill all fields.');
        return;
    }

    try {
        const response = await fetch(`/api/students/${id}`, {
            method: 'PUT',
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify(student),
        });

        if (!response.ok) {
            const data = await response.json();
            throw new Error(data?.message || 'Could not update student.');
        }

        document.getElementById('updateId').value = '';
        document.getElementById('updateName').value = '';
        document.getElementById('updateAge').value = '';
        document.getElementById('updateCourse').value = '';
        await loadStudents();
        showMessage('Student updated successfully.', 'success');
    } catch (error) {
        showMessage(error.message);
    }
}

async function searchStudent() {
    const id = Number(document.getElementById('searchId').value);
    if (!id) {
        showMessage('Enter an ID to search.');
        return;
    }

    try {
        const response = await fetch(`/api/students/${id}`);
        if (!response.ok) {
            throw new Error('Student not found.');
        }

        const student = await response.json();
        renderStudents([student]);
        showMessage('Search result loaded.', 'success');
    } catch (error) {
        showMessage(error.message);
    }
}

async function deleteStudent(id) {
    try {
        const response = await fetch(`/api/students/${id}`, { method: 'DELETE' });
        if (!response.ok) {
            throw new Error('Could not delete student.');
        }

        await loadStudents();
        showMessage('Student deleted successfully.', 'success');
    } catch (error) {
        showMessage(error.message);
    }
}

window.onload = loadStudents;
