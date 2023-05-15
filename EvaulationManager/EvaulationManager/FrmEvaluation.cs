using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBLayer;

namespace EvaulationManager {
    public partial class FrmEvaluation : Form {
        private Student student;

        public FrmEvaluation(Student selectedStudent) {
            InitializeComponent();
            student = selectedStudent;
        }

        private void SetFormText() {
            Text = student.FirstName + " " + student.LastName;
        }
        private void btnCancel_Click(object sender, EventArgs e) {
            Close();
        }

        private void cboActivities_SelectedIndexChanged_1(object sender, EventArgs e) {
            var currentActivity = cboActivities.SelectedItem as Activity;
            txtActivityDescription.Text = currentActivity.Description;
            txtMinForGrade.Text = currentActivity.MinPointsForGrade + "/" +
           currentActivity.MaxPoints;
            txtMinForSignature.Text = currentActivity.MinPointsForSignature + "/" +
           currentActivity.MaxPoints;
            numPoints.Minimum = 0;
            numPoints.Maximum = currentActivity.MaxPoints;
        }
        private void FrmEvaluation_Load_1(object sender, EventArgs e) {
            SetFormText();
            var activities = ActivityRepository.GetActivities();
            cboActivities.DataSource = activities;
        }
    }
}
