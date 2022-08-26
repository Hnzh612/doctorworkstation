import request from "@/utils/requset";

// 获取所有文章
const GetAllArticle = (page) => {
    return request.get('Articl/GetAllArticle?page='+page)
}

// 添加文章
const AddArticle = (Article) => {
    return request.post('Article/AddArticle',Article)
}

// 根据id获取文章信息
const GetArticleById = (id) => {
    return request.get('Article/GrtArticleById?id='+id)
}
// 新建某月进销存总和
const AddSum = (invoicingledgercssum) => {
    return request.post('invoicing/addsum',invoicingledgercssum)
}

// 删除当月进销存总和以及所连接的栏目
const DelSum = (sid) => {
    return request.get('invoicing/delsum?sid=' + sid)
}

// 更新当月进销存总和
const UpdateSum = (invoicingledgercssum) => {
    return request.post('invoicing/updatesum',invoicingledgercssum)
}

// 根据sid获取相应的进销存
const GetAllLedgercs = (sid) => {
    return request.get('invoicing/GetAllLedgercsBySid?sid=' + sid)
}

// 添加进销存栏目
const AddLedgercs = (invoicing) => {
    return request.post('invoicing/addledgercs',invoicing)
}

// 删除进销存栏目
const DelLedgercs = (id) => {
    return request.get('invoicing/delledgercs?id=' + id)
}
export default {
    GetAllArticle,
    AddArticle,
    GetArticleById,
    AddSum,
    DelSum,
    UpdateSum,
    GetAllLedgercs,
    AddLedgercs,
    DelLedgercs
}