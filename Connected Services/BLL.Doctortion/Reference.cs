﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp.BLL.Doctortion {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BLL.Doctortion.Doctortion")]
    public interface Doctortion {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Doctortion/btndoctor", ReplyAction="http://tempuri.org/Doctortion/btndoctorResponse")]
        System.Data.DataSet btndoctor();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Doctortion/btndoctor", ReplyAction="http://tempuri.org/Doctortion/btndoctorResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> btndoctorAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Doctortion/btnprescribing", ReplyAction="http://tempuri.org/Doctortion/btnprescribingResponse")]
        System.Data.DataSet btnprescribing();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Doctortion/btnprescribing", ReplyAction="http://tempuri.org/Doctortion/btnprescribingResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> btnprescribingAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Doctortion/btncycle", ReplyAction="http://tempuri.org/Doctortion/btncycleResponse")]
        System.Data.DataSet btncycle();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Doctortion/btncycle", ReplyAction="http://tempuri.org/Doctortion/btncycleResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> btncycleAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Doctortion/btndrug", ReplyAction="http://tempuri.org/Doctortion/btndrugResponse")]
        System.Data.DataSet btndrug();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Doctortion/btndrug", ReplyAction="http://tempuri.org/Doctortion/btndrugResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> btndrugAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Doctortion/btnAnformation", ReplyAction="http://tempuri.org/Doctortion/btnAnformationResponse")]
        int btnAnformation(int ID, int cboPrescribing, int cbocycle, System.DateTime dtmentry_date, string txt_Name, string txt_Nae, string Note);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Doctortion/btnAnformation", ReplyAction="http://tempuri.org/Doctortion/btnAnformationResponse")]
        System.Threading.Tasks.Task<int> btnAnformationAsync(int ID, int cboPrescribing, int cbocycle, System.DateTime dtmentry_date, string txt_Name, string txt_Nae, string Note);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Doctortion/btnStoc", ReplyAction="http://tempuri.org/Doctortion/btnStocResponse")]
        int btnStoc(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Doctortion/btnStoc", ReplyAction="http://tempuri.org/Doctortion/btnStocResponse")]
        System.Threading.Tasks.Task<int> btnStocAsync(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Doctortion/btndruggo", ReplyAction="http://tempuri.org/Doctortion/btndruggoResponse")]
        System.Data.DataSet btndruggo(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Doctortion/btndruggo", ReplyAction="http://tempuri.org/Doctortion/btndruggoResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> btndruggoAsync(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Doctortion/btnmedicine", ReplyAction="http://tempuri.org/Doctortion/btnmedicineResponse")]
        System.Data.DataSet btnmedicine();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Doctortion/btnmedicine", ReplyAction="http://tempuri.org/Doctortion/btnmedicineResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> btnmedicineAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Doctortion/btnChine", ReplyAction="http://tempuri.org/Doctortion/btnChineResponse")]
        System.Data.DataSet btnChine();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Doctortion/btnChine", ReplyAction="http://tempuri.org/Doctortion/btnChineResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> btnChineAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Doctortion/btnCtheprice", ReplyAction="http://tempuri.org/Doctortion/btnCthepriceResponse")]
        System.Data.DataSet btnCtheprice(string intJG);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Doctortion/btnCtheprice", ReplyAction="http://tempuri.org/Doctortion/btnCthepriceResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> btnCthepriceAsync(string intJG);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Doctortion/btnWmedicine", ReplyAction="http://tempuri.org/Doctortion/btnWmedicineResponse")]
        System.Data.DataSet btnWmedicine();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Doctortion/btnWmedicine", ReplyAction="http://tempuri.org/Doctortion/btnWmedicineResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> btnWmedicineAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Doctortion/btnXdicine", ReplyAction="http://tempuri.org/Doctortion/btnXdicineResponse")]
        System.Data.DataSet btnXdicine(string intJG);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Doctortion/btnXdicine", ReplyAction="http://tempuri.org/Doctortion/btnXdicineResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> btnXdicineAsync(string intJG);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Doctortion/btnStatebing", ReplyAction="http://tempuri.org/Doctortion/btnStatebingResponse")]
        System.Data.DataSet btnStatebing(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Doctortion/btnStatebing", ReplyAction="http://tempuri.org/Doctortion/btnStatebingResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> btnStatebingAsync(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Doctortion/btnakeway", ReplyAction="http://tempuri.org/Doctortion/btnakewayResponse")]
        System.Data.DataSet btnakeway();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Doctortion/btnakeway", ReplyAction="http://tempuri.org/Doctortion/btnakewayResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> btnakewayAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Doctortion/btninformation", ReplyAction="http://tempuri.org/Doctortion/btninformationResponse")]
        int btninformation(int ID, int cboType, int cboname, int cbocycle, decimal txtprice, int txtUumber, string Note);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Doctortion/btninformation", ReplyAction="http://tempuri.org/Doctortion/btninformationResponse")]
        System.Threading.Tasks.Task<int> btninformationAsync(int ID, int cboType, int cboname, int cbocycle, decimal txtprice, int txtUumber, string Note);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Doctortion/btndelete", ReplyAction="http://tempuri.org/Doctortion/btndeleteResponse")]
        int btndelete(int UID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Doctortion/btndelete", ReplyAction="http://tempuri.org/Doctortion/btndeleteResponse")]
        System.Threading.Tasks.Task<int> btndeleteAsync(int UID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Doctortion/btnadvice", ReplyAction="http://tempuri.org/Doctortion/btnadviceResponse")]
        int btnadvice(int ID, int cboPrescribing, int cbocycle, string txt_Name, string txt_Nae, string Note);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Doctortion/btnadvice", ReplyAction="http://tempuri.org/Doctortion/btnadviceResponse")]
        System.Threading.Tasks.Task<int> btnadviceAsync(int ID, int cboPrescribing, int cbocycle, string txt_Name, string txt_Nae, string Note);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Doctortion/btndeleteadvice", ReplyAction="http://tempuri.org/Doctortion/btndeleteadviceResponse")]
        int btndeleteadvice(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Doctortion/btndeleteadvice", ReplyAction="http://tempuri.org/Doctortion/btndeleteadviceResponse")]
        System.Threading.Tasks.Task<int> btndeleteadviceAsync(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Doctortion/btnorders", ReplyAction="http://tempuri.org/Doctortion/btnordersResponse")]
        System.Data.DataSet btnorders();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Doctortion/btnorders", ReplyAction="http://tempuri.org/Doctortion/btnordersResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> btnordersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Doctortion/btnperfrom", ReplyAction="http://tempuri.org/Doctortion/btnperfromResponse")]
        int btnperfrom(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Doctortion/btnperfrom", ReplyAction="http://tempuri.org/Doctortion/btnperfromResponse")]
        System.Threading.Tasks.Task<int> btnperfromAsync(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Doctortion/btnoperationtype", ReplyAction="http://tempuri.org/Doctortion/btnoperationtypeResponse")]
        System.Data.DataSet btnoperationtype();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Doctortion/btnoperationtype", ReplyAction="http://tempuri.org/Doctortion/btnoperationtypeResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> btnoperationtypeAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Doctortion/btnDeterminetype", ReplyAction="http://tempuri.org/Doctortion/btnDeterminetypeResponse")]
        System.Data.DataSet btnDeterminetype();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Doctortion/btnDeterminetype", ReplyAction="http://tempuri.org/Doctortion/btnDeterminetypeResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> btnDeterminetypeAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Doctortion/btnPatientstype", ReplyAction="http://tempuri.org/Doctortion/btnPatientstypeResponse")]
        System.Data.DataSet btnPatientstype();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Doctortion/btnPatientstype", ReplyAction="http://tempuri.org/Doctortion/btnPatientstypeResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> btnPatientstypeAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Doctortion/btnoperating", ReplyAction="http://tempuri.org/Doctortion/btnoperatingResponse")]
        System.Data.DataSet btnoperating();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Doctortion/btnoperating", ReplyAction="http://tempuri.org/Doctortion/btnoperatingResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> btnoperatingAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Doctortion/btndepartment", ReplyAction="http://tempuri.org/Doctortion/btndepartmentResponse")]
        System.Data.DataSet btndepartment();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Doctortion/btndepartment", ReplyAction="http://tempuri.org/Doctortion/btndepartmentResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> btndepartmentAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Doctortion/btnurgent", ReplyAction="http://tempuri.org/Doctortion/btnurgentResponse")]
        System.Data.DataSet btnurgent();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Doctortion/btnurgent", ReplyAction="http://tempuri.org/Doctortion/btnurgentResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> btnurgentAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Doctortion/btnapplication", ReplyAction="http://tempuri.org/Doctortion/btnapplicationResponse")]
        int btnapplication(int ID, string UID, int cbourgent, int cbodepartment, int cbobetween, string txtoperation, System.DateTime txtTotime, int cbodisease, string txtreport, string txtAllergic, string txtapplicant, int cboPatients, System.DateTime dtpEnterDate, int cbotype);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Doctortion/btnapplication", ReplyAction="http://tempuri.org/Doctortion/btnapplicationResponse")]
        System.Threading.Tasks.Task<int> btnapplicationAsync(int ID, string UID, int cbourgent, int cbodepartment, int cbobetween, string txtoperation, System.DateTime txtTotime, int cbodisease, string txtreport, string txtAllergic, string txtapplicant, int cboPatients, System.DateTime dtpEnterDate, int cbotype);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface DoctortionChannel : WpfApp.BLL.Doctortion.Doctortion, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DoctortionClient : System.ServiceModel.ClientBase<WpfApp.BLL.Doctortion.Doctortion>, WpfApp.BLL.Doctortion.Doctortion {
        
        public DoctortionClient() {
        }
        
        public DoctortionClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DoctortionClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DoctortionClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DoctortionClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet btndoctor() {
            return base.Channel.btndoctor();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> btndoctorAsync() {
            return base.Channel.btndoctorAsync();
        }
        
        public System.Data.DataSet btnprescribing() {
            return base.Channel.btnprescribing();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> btnprescribingAsync() {
            return base.Channel.btnprescribingAsync();
        }
        
        public System.Data.DataSet btncycle() {
            return base.Channel.btncycle();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> btncycleAsync() {
            return base.Channel.btncycleAsync();
        }
        
        public System.Data.DataSet btndrug() {
            return base.Channel.btndrug();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> btndrugAsync() {
            return base.Channel.btndrugAsync();
        }
        
        public int btnAnformation(int ID, int cboPrescribing, int cbocycle, System.DateTime dtmentry_date, string txt_Name, string txt_Nae, string Note) {
            return base.Channel.btnAnformation(ID, cboPrescribing, cbocycle, dtmentry_date, txt_Name, txt_Nae, Note);
        }
        
        public System.Threading.Tasks.Task<int> btnAnformationAsync(int ID, int cboPrescribing, int cbocycle, System.DateTime dtmentry_date, string txt_Name, string txt_Nae, string Note) {
            return base.Channel.btnAnformationAsync(ID, cboPrescribing, cbocycle, dtmentry_date, txt_Name, txt_Nae, Note);
        }
        
        public int btnStoc(int ID) {
            return base.Channel.btnStoc(ID);
        }
        
        public System.Threading.Tasks.Task<int> btnStocAsync(int ID) {
            return base.Channel.btnStocAsync(ID);
        }
        
        public System.Data.DataSet btndruggo(int ID) {
            return base.Channel.btndruggo(ID);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> btndruggoAsync(int ID) {
            return base.Channel.btndruggoAsync(ID);
        }
        
        public System.Data.DataSet btnmedicine() {
            return base.Channel.btnmedicine();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> btnmedicineAsync() {
            return base.Channel.btnmedicineAsync();
        }
        
        public System.Data.DataSet btnChine() {
            return base.Channel.btnChine();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> btnChineAsync() {
            return base.Channel.btnChineAsync();
        }
        
        public System.Data.DataSet btnCtheprice(string intJG) {
            return base.Channel.btnCtheprice(intJG);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> btnCthepriceAsync(string intJG) {
            return base.Channel.btnCthepriceAsync(intJG);
        }
        
        public System.Data.DataSet btnWmedicine() {
            return base.Channel.btnWmedicine();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> btnWmedicineAsync() {
            return base.Channel.btnWmedicineAsync();
        }
        
        public System.Data.DataSet btnXdicine(string intJG) {
            return base.Channel.btnXdicine(intJG);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> btnXdicineAsync(string intJG) {
            return base.Channel.btnXdicineAsync(intJG);
        }
        
        public System.Data.DataSet btnStatebing(int ID) {
            return base.Channel.btnStatebing(ID);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> btnStatebingAsync(int ID) {
            return base.Channel.btnStatebingAsync(ID);
        }
        
        public System.Data.DataSet btnakeway() {
            return base.Channel.btnakeway();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> btnakewayAsync() {
            return base.Channel.btnakewayAsync();
        }
        
        public int btninformation(int ID, int cboType, int cboname, int cbocycle, decimal txtprice, int txtUumber, string Note) {
            return base.Channel.btninformation(ID, cboType, cboname, cbocycle, txtprice, txtUumber, Note);
        }
        
        public System.Threading.Tasks.Task<int> btninformationAsync(int ID, int cboType, int cboname, int cbocycle, decimal txtprice, int txtUumber, string Note) {
            return base.Channel.btninformationAsync(ID, cboType, cboname, cbocycle, txtprice, txtUumber, Note);
        }
        
        public int btndelete(int UID) {
            return base.Channel.btndelete(UID);
        }
        
        public System.Threading.Tasks.Task<int> btndeleteAsync(int UID) {
            return base.Channel.btndeleteAsync(UID);
        }
        
        public int btnadvice(int ID, int cboPrescribing, int cbocycle, string txt_Name, string txt_Nae, string Note) {
            return base.Channel.btnadvice(ID, cboPrescribing, cbocycle, txt_Name, txt_Nae, Note);
        }
        
        public System.Threading.Tasks.Task<int> btnadviceAsync(int ID, int cboPrescribing, int cbocycle, string txt_Name, string txt_Nae, string Note) {
            return base.Channel.btnadviceAsync(ID, cboPrescribing, cbocycle, txt_Name, txt_Nae, Note);
        }
        
        public int btndeleteadvice(int ID) {
            return base.Channel.btndeleteadvice(ID);
        }
        
        public System.Threading.Tasks.Task<int> btndeleteadviceAsync(int ID) {
            return base.Channel.btndeleteadviceAsync(ID);
        }
        
        public System.Data.DataSet btnorders() {
            return base.Channel.btnorders();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> btnordersAsync() {
            return base.Channel.btnordersAsync();
        }
        
        public int btnperfrom(int ID) {
            return base.Channel.btnperfrom(ID);
        }
        
        public System.Threading.Tasks.Task<int> btnperfromAsync(int ID) {
            return base.Channel.btnperfromAsync(ID);
        }
        
        public System.Data.DataSet btnoperationtype() {
            return base.Channel.btnoperationtype();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> btnoperationtypeAsync() {
            return base.Channel.btnoperationtypeAsync();
        }
        
        public System.Data.DataSet btnDeterminetype() {
            return base.Channel.btnDeterminetype();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> btnDeterminetypeAsync() {
            return base.Channel.btnDeterminetypeAsync();
        }
        
        public System.Data.DataSet btnPatientstype() {
            return base.Channel.btnPatientstype();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> btnPatientstypeAsync() {
            return base.Channel.btnPatientstypeAsync();
        }
        
        public System.Data.DataSet btnoperating() {
            return base.Channel.btnoperating();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> btnoperatingAsync() {
            return base.Channel.btnoperatingAsync();
        }
        
        public System.Data.DataSet btndepartment() {
            return base.Channel.btndepartment();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> btndepartmentAsync() {
            return base.Channel.btndepartmentAsync();
        }
        
        public System.Data.DataSet btnurgent() {
            return base.Channel.btnurgent();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> btnurgentAsync() {
            return base.Channel.btnurgentAsync();
        }
        
        public int btnapplication(int ID, string UID, int cbourgent, int cbodepartment, int cbobetween, string txtoperation, System.DateTime txtTotime, int cbodisease, string txtreport, string txtAllergic, string txtapplicant, int cboPatients, System.DateTime dtpEnterDate, int cbotype) {
            return base.Channel.btnapplication(ID, UID, cbourgent, cbodepartment, cbobetween, txtoperation, txtTotime, cbodisease, txtreport, txtAllergic, txtapplicant, cboPatients, dtpEnterDate, cbotype);
        }
        
        public System.Threading.Tasks.Task<int> btnapplicationAsync(int ID, string UID, int cbourgent, int cbodepartment, int cbobetween, string txtoperation, System.DateTime txtTotime, int cbodisease, string txtreport, string txtAllergic, string txtapplicant, int cboPatients, System.DateTime dtpEnterDate, int cbotype) {
            return base.Channel.btnapplicationAsync(ID, UID, cbourgent, cbodepartment, cbobetween, txtoperation, txtTotime, cbodisease, txtreport, txtAllergic, txtapplicant, cboPatients, dtpEnterDate, cbotype);
        }
    }
}
