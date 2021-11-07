var AssessmentEngine = window.AssessmentEngine || {};

AssessmentEngine.Pageable = function(collection, pageSize, maxDisplayPages) {
    if (!Array.isArray(collection)) {
        throw new Error('Invalid argument: collection');
    }
    
    this.collection = collection;
    this.pageSize = pageSize || 5; 
    this.maxDisplayPages = maxDisplayPages || 10;
}

AssessmentEngine.Pageable.prototype.getPage = function(pageIndex) {
    if (pageIndex > this.pageCount() || !this.collection) {
        return [];
    }
    
    const skip = this.pageSize * pageIndex;
    
    return this.collection.slice(skip, skip + this.pageSize);
}

AssessmentEngine.Pageable.prototype.getPages = function() {
    const pages = [];
    
    for (let i = 0; i < this.pageCount(); i++) {
        pages.push(i + 1);
    }
    
    return pages;
}

AssessmentEngine.Pageable.prototype.getDisplayPages = function(shiftCount) {
    const pages = this.getPages();
    shiftCount = shiftCount || 0;
    
    if (pages.length > this.maxDisplayPages) {
        const deleteCount = pages.length - this.maxDisplayPages - shiftCount;

        if (shiftCount > 0) {
            pages.splice(0, shiftCount);
        }
        
        pages.splice(this.maxDisplayPages, deleteCount);
    }

    return pages;
}

AssessmentEngine.Pageable.prototype.itemCount = function() {
    return this.collection.length;
}

AssessmentEngine.Pageable.prototype.pageCount = function() {
    return Math.ceil(this.collection.length / this.pageSize);
}

AssessmentEngine.Pageable.prototype.pageItemCount = function(pageIndex) {
    return pageIndex < this.pageCount()
        ? Math.min(this.pageSize, this.collection.length - pageIndex * this.pageSize)
        : -1;
}

AssessmentEngine.Pageable.prototype.pageIndex = function(itemIndex) {
    return itemIndex < this.collection.length && itemIndex >= 0
        ? Math.floor(itemIndex / this.pageSize)
        : -1;
}
